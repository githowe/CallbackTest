#include "LibMain.h"

void SetCallback(Callback callback)
{
	g_callback = callback;
}

void Start()
{
	BYTE* data = new BYTE[1024];
	while (true)
	{
		g_callback(data);
	}
}
