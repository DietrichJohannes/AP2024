#include <windows.h>
#include <commdlg.h>
#include <shlobj.h>
#include <urlmon.h>
#include <string>
#include <iostream>

#pragma comment(lib, "urlmon.lib")

const std::string DOWNLOAD_URL = "https://github.com/DietrichJohannes/AP2024/releases/download/AP2024/AP2024.exe";
const std::string INSTALL_FILE = "AP2024.exe";

// Globale Variablen für das Fenster und das Eingabefeld
HWND hInstallPathEdit, hStatusLabel;

// Funktion zum Öffnen eines Dialogs zur Auswahl des Installationsverzeichnisses
std::string openFolderDialog(HWND hwnd) {
    BROWSEINFO bi = {0};
    bi.lpszTitle = "Installationsverzeichnis wählen";
    bi.ulFlags = BIF_RETURNONLYFSDIRS | BIF_NEWDIALOGSTYLE;

    LPITEMIDLIST pidl = SHBrowseForFolder(&bi);
    if (pidl) {
        char path[MAX_PATH];
        if (SHGetPathFromIDList(pidl, path)) {
            return std::string(path);
        }
    }
    return "";
}

// Funktion zum Herunterladen der Datei von GitHub
bool downloadFile(const std::string& url, const std::string& destination) {
    HRESULT hr = URLDownloadToFileA(NULL, url.c_str(), destination.c_str(), 0, NULL);
    return hr == S_OK;
}

// Funktion zur Erstellung einer Verknüpfung auf dem Desktop
void createShortcut(const std::string& targetPath) {
    char desktopPath[MAX_PATH];
    if (SUCCEEDED(SHGetFolderPathA(NULL, CSIDL_DESKTOP, NULL, 0, desktopPath))) {
        std::string shortcutPath = std::string(desktopPath) + "\\AP2024.lnk";

        HRESULT hres;
        IShellLink* pShellLink = nullptr;
        IPersistFile* pPersistFile = nullptr;

        CoInitialize(nullptr);

        hres = CoCreateInstance(CLSID_ShellLink, NULL, CLSCTX_INPROC_SERVER, IID_IShellLink, (void**)&pShellLink);
        if (SUCCEEDED(hres)) {
            pShellLink->SetPath(targetPath.c_str());
            pShellLink->SetDescription("AP2024");

            hres = pShellLink->QueryInterface(IID_IPersistFile, (void**)&pPersistFile);
            if (SUCCEEDED(hres)) {
                std::wstring wShortcutPath(shortcutPath.begin(), shortcutPath.end());
                pPersistFile->Save(wShortcutPath.c_str(), TRUE);
                pPersistFile->Release();
            }
            pShellLink->Release();
        }
        CoUninitialize();
    }
}

// Hauptfenster Callback-Funktion
LRESULT CALLBACK WindowProcedure(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam) {
    switch (message) {
        case WM_COMMAND:
            if (LOWORD(wParam) == 1) {  // Installationspfad wählen
                std::string path = openFolderDialog(hwnd);
                if (!path.empty()) {
                    SetWindowText(hInstallPathEdit, path.c_str());
                }
            } else if (LOWORD(wParam) == 2) {  // Installation starten
                char installPath[MAX_PATH];
                GetWindowText(hInstallPathEdit, installPath, MAX_PATH);

                if (strlen(installPath) == 0) {
                    MessageBox(hwnd, "Bitte wählen Sie einen Installationspfad!", "Fehler", MB_OK | MB_ICONERROR);
                    return 0;
                }

                std::string fullPath = std::string(installPath) + "\\" + INSTALL_FILE;

                SetWindowText(hStatusLabel, "Lade Datei herunter...");
                if (downloadFile(DOWNLOAD_URL, fullPath)) {
                    SetWindowText(hStatusLabel, "Download erfolgreich!");

                    createShortcut(fullPath);
                    MessageBox(hwnd, "Installation erfolgreich!", "Fertig", MB_OK | MB_ICONINFORMATION);
                } else {
                    MessageBox(hwnd, "Fehler beim Herunterladen der Datei!", "Fehler", MB_OK | MB_ICONERROR);
                }
            }
            break;
        case WM_CLOSE:
            DestroyWindow(hwnd);
            break;
        case WM_DESTROY:
            PostQuitMessage(0);
            break;
        default:
            return DefWindowProc(hwnd, message, wParam, lParam);
    }
    return 0;
}

// Hauptprogramm
int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow) {
    WNDCLASS wc = {};
    wc.lpfnWndProc = WindowProcedure;
    wc.hInstance = hInstance;
    wc.lpszClassName = "InstallerWindow";
    RegisterClass(&wc);

    HWND hwnd = CreateWindow("InstallerWindow", "AP2024 Installer",
                             WS_OVERLAPPEDWINDOW | WS_VISIBLE,
                             CW_USEDEFAULT, CW_USEDEFAULT, 500, 200,
                             NULL, NULL, hInstance, NULL);

    CreateWindow("STATIC", "Installationspfad:", WS_VISIBLE | WS_CHILD, 20, 20, 120, 20, hwnd, NULL, hInstance, NULL);
    hInstallPathEdit = CreateWindow("EDIT", "", WS_VISIBLE | WS_CHILD | WS_BORDER | ES_AUTOHSCROLL,
                                    150, 20, 250, 20, hwnd, NULL, hInstance, NULL);
    CreateWindow("BUTTON", "Wählen...", WS_VISIBLE | WS_CHILD, 410, 20, 70, 20, hwnd, (HMENU)1, hInstance, NULL);

    CreateWindow("BUTTON", "Installieren", WS_VISIBLE | WS_CHILD | BS_DEFPUSHBUTTON,
                 150, 60, 120, 30, hwnd, (HMENU)2, hInstance, NULL);

    hStatusLabel = CreateWindow("STATIC", "", WS_VISIBLE | WS_CHILD, 150, 100, 250, 20, hwnd, NULL, hInstance, NULL);

    MSG msg = {};
    while (GetMessage(&msg, NULL, 0, 0)) {
        TranslateMessage(&msg);
        DispatchMessage(&msg);
    }
    return 0;
}
