#pragma once

#include <Windows.h>

typedef void(*Callback)(void*);

Callback g_callback = nullptr;

extern "C" __declspec(dllexport) void SetCallback(Callback callback);

extern "C" __declspec(dllexport) void Start();