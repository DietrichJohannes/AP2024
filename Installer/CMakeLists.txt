cmake_minimum_required(VERSION 3.28)
project(Installer)

set(CMAKE_CXX_STANDARD 17)

add_executable(Installer main.cpp)

# Windows-Bibliotheken einbinden
target_link_libraries(Installer PRIVATE urlmon ole32 oleaut32 uuid)

set(CMAKE_EXE_LINKER_FLAGS "-static")