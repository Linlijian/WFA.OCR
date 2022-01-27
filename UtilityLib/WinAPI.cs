using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UtilityLib
{
	public class WinAPI
	{
		public const int WM_KEYDOWN = 0x100;
		public const int WM_KEYUP = 0x101;
		public const int WM_COMMAND = 0x111;
		public const int WM_LBUTTONDOWN = 0x201;
		public const int WM_LBUTTONUP = 0x202;
		public const int WM_LBUTTONDBLCLK = 0x203;
		public const int WM_RBUTTONDOWN = 0x204;
		public const int WM_RBUTTONUP = 0x205;
		public const int WM_RBUTTONDBLCLK = 0x206;

		[DllImport("User32.dll")]
		public static extern IntPtr FindWindow(string strClassName, string strWindowName);

		[DllImport("User32.dll")]
		public static extern Int32 SendMessage(
			int hWnd,               // handle to destination window
			int Msg,                // message
			int wParam,             // first message parameter
			[MarshalAs(UnmanagedType.LPStr)] string lParam); // second message parameter

		[DllImport("User32.dll")]
		public static extern Int32 SendMessageW(
		   int hWnd,               // handle to destination window
		   int Msg,                // message
		   int wParam,             // first message parameter
		   int lParam);            // second message parameter

		[DllImport("User32.dll")]
		public static extern Int32 SendMessage(
			int hWnd,               // handle to destination window
			int Msg,                // message
			int wParam,             // first message parameter
			int lParam);            // second message parameter


		[DllImport("User32.dll")]
		public static extern int FindWindowEx(
				int hwndParent,
				int hwndChildAfter,
				string strClassName,
				string strWindowName);

		[DllImport("user32.dll")]
		static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

		[DllImport("user32.dll")]
		internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

#pragma warning disable 649
		internal struct INPUT
		{
			public UInt32 Type;
			public MOUSEKEYBDHARDWAREINPUT Data;
		}

		[StructLayout(LayoutKind.Explicit)]
		internal struct MOUSEKEYBDHARDWAREINPUT
		{
			[FieldOffset(0)]
			public MOUSEINPUT Mouse;
		}

		internal struct MOUSEINPUT
		{
			public Int32 X;
			public Int32 Y;
			public UInt32 MouseData;
			public UInt32 Flags;
			public UInt32 Time;
			public IntPtr ExtraInfo;
		}
#pragma warning restore 649

		public static IntPtr CreateLParam(int LoWord, int HiWord)
		{
			return (IntPtr)((HiWord << 16) | (LoWord & 0xffff));
		}
		public static void ClickOnPoint(IntPtr wndHandle, Point clientPoint)
		{
			var oldPos = Cursor.Position;

			/// get screen coordinates
			ClientToScreen(wndHandle, ref clientPoint);

			/// set cursor on coords, and press mouse
			Cursor.Position = new Point(clientPoint.X, clientPoint.Y);

			var inputMouseDown = new INPUT();
			inputMouseDown.Type = 0; /// input type mouse
			inputMouseDown.Data.Mouse.Flags = 0x0002; /// left button down

			var inputMouseUp = new INPUT();
			inputMouseUp.Type = 0; /// input type mouse
			inputMouseUp.Data.Mouse.Flags = 0x0004; /// left button up

			var inputs = new INPUT[] { inputMouseDown, inputMouseUp };
			SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

			/// return mouse 
			Cursor.Position = oldPos;
		}




		public const int BLACKNESS = 0x00000042;
		public const int DSINVERT = 0x00550009;
		public const int MERGECOPY = 0x00C000CA;
		public const int MERGEPAINT = 0x00BB0226;
		public const int NOTSRCCOPY = 0x00330008;
		public const int NOTSRCERASE = 0x001100A6;
		public const int PATCOPY = 0x00F00021;
		public const int PATINVERT = 0x005A0049;
		public const int PATPAINT = 0x00FB0A09;
		public const int SRCAND = 0x008800C6;
		public const int SRCCOPY = 0x00CC0020;
		public const int SRCERASE = 0x00440328;
		public const int SRCINVERT = 0x00660046;
		public const int SRCPAINT = 0x00EE0086;
		public const int WHITENESS = 0x00FF0062;

		[DllImport("gdi32.dll")]
		public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest,
			int nWidth, int nHeight, IntPtr hObjectSource,
			int nXSrc, int nYSrc, int dwRop);
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
		[DllImport("gdi32.dll")]
		public static extern bool DeleteDC(IntPtr hDC);
		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);
		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

		[StructLayout(LayoutKind.Sequential)]
		public struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}

		[DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
		public static extern IntPtr GetDesktopWindow();
		[DllImport("user32.dll", EntryPoint = "GetDC")]
		public static extern IntPtr GetDC(IntPtr ptr);
		[DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
		public static extern int GetSystemMetrics(int abc);
		[DllImport("user32.dll", EntryPoint = "GetWindowDC")]
		public static extern IntPtr GetWindowDC(IntPtr ptr);
		[DllImport("user32.dll", EntryPoint = "ReleaseDC")]
		public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);
		[DllImport("user32.dll")]
		public static extern IntPtr PrintWindow(IntPtr hwnd, IntPtr hdcBlt, int nFlags);
		[DllImport("user32.dll")]
		public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern int SendMessageA(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern int SendMessageW(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern int SetForegroundWindow(IntPtr hWnd);


		//This is a replacement for Cursor.Position in WinForms
		[DllImport("user32.dll")]
		static extern bool SetCursorPos(int x, int y);

		[DllImport("user32.dll")]
		static extern void SetActiveWindow(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		[DllImport("user32.dll")]
		public static extern bool GetCursorPos(out POINT lpPoint);

		[StructLayout(LayoutKind.Sequential)]
		public struct POINT
		{
			public int X;
			public int Y;

			public static implicit operator Point(POINT point)
			{
				return new Point(point.X, point.Y);
			}
		}

		public const int MOUSEEVENTF_LEFTDOWN = 0x02;
		public const int MOUSEEVENTF_LEFTUP = 0x04;

		
	}
}

