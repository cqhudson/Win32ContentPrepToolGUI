# Win32ContentPrepToolGUI

`Win32ContentPrepToolGUI` is an open source wrapper for the [Win32 Content Prep Tool](https://github.com/Microsoft/Microsoft-Win32-Content-Prep-Tool) by Microsoft.

You must download the `IntuneWinAppUtil.exe` executable from the official Microsoft repo before running this application. This is simply a wrapper and requires the executable to pack your apps to `.intunewin` format.

Written in Visual Basic .NET, `Win32ContentPrepToolGUI` is a Windows Forms Application. This simplifies the process of selecting parameters for the prep tool.

# How to use

Go to the **Releases** tab and download the latest version of `WIn32ContentPrepToolGUI.exe` (Microsoft Defender or Smart Screen will flag this app, this is expected. Just tell Smart Screen or Defender to keep the app).

Download the official [Win32 Content Prep Tool (IntuneWinAppUtil.exe)](https://github.com/Microsoft/Microsoft-Win32-Content-Prep-Tool) from Microsoft's official repo.


**Steps here are written in order of top to bottom (from the top of the GUI to the bottom)**

1. Press the `Select File` button and select the `IntuneWinAppUtil.exe`. 
2. Press the `Select File` button and select the setup file (This is usually a `setup.msi` or `setup.exe`).
3. Press the `Select Folder` button and select the setup folder (All files in this folder will be packaged into the `.intunewin` format.
4. Press the `Select Folder` button and select the output folder (This is where the `.intunewin` will be saved).
5. The `Select catalog folder` TextBox and its respective `Select Folder` Button will be disabled until you specify `yes` or `no` using the `CatalogFolder` CheckBox. If the CheckBox is Checked (True) then the TextBox and Button will be enabled and you must choose a catalog foler to continue.
6. (OPTIONAL) - Choose whether or not you want to use Quiet Mode when generating your `.intunewin` file. By default, this is disabled.
7. Press the `Generate` button
8. Celebrate, because you can now upload your `.intunewin` file to Intune, and you didn't have to type in those long file paths to do it.

![Win32ContentPrepToolGUI_1](https://user-images.githubusercontent.com/36829070/230744715-4b676d32-0818-4d84-b05a-c3d820c60da1.jpg)

### **Autofill `IntuneWinAppUtil.exe`**

To tell this app where IntuneWinAppUtil.exe is stored, you can use the registry editor. Go to the following key: `HKEY_CURRENT_USER\SOFTWARE\WIN32_CONTENT_PREP_TOOL_GUI_CONFIG`.

Inside that key is a value called `IntuneWinAppUtil_Location`. The default value is set to `C:\IWAU\IntuneWinAppUtil.exe`. Change this to whatever value you want. If the app finds the util tool at that location, it will autofill the value every time you run the GUI.

Here are some valid example values for `IntuneWinAppUtil_Location`:
1. `C:\Intune Utils\Microsoft\IntuneWinAppUtil.exe`
2. `C:\Users\username\Documents\IntuneWinAppUtil.exe`
3. `C:\Tools\Intune Tools\Microsoft Win32 Content Prep Tool\IntuneWinAppUtil.exe`
