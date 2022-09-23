# Win32ContentPrepToolGUI

`Win32ContentPrepToolGUI` is an open source wrapper for the [Win32 Content Prep Tool](https://github.com/Microsoft/Microsoft-Win32-Content-Prep-Tool) by Microsoft. I got tired of having to manually type in file paths without autocompletion, so now we can use a nice GUI to select file paths.

You must download the `IntuneWinAppUtil.exe` executable from the official Microsoft repo before running this application. This is simply a wrapper and requires the executable to pack your apps to `.intunewin` format.

Written in Visual Basic .NET, `Win32ContentPrepToolGUI` is a Windows Forms Application. This simplifies the process of selecting parameters for the prep tool.

# How to use

Go to the **Releases** tab and download the latest version of WIn32ContentPrepToolGUI.exe (There is a 32 bit and a 64 bit version of each release)

Download the official [Win32 Content Prep Tool (IntuneWinAppUtil.exe)](https://github.com/Microsoft/Microsoft-Win32-Content-Prep-Tool) from Microsoft's official repo.


**Steps here are written in order of top to bottom (from the top of the GUI to the bottom)**

1. Press the `Select File` button and select the `IntuneWinAppUtil.exe` (If you don't, unexpected things will happen!).
2. Press the `Select File` button and select the setup file (This is usually a `setup.msi` or `setup.exe`).
3. Press the `Select Folder` button and select the setup folder (All files in this folder will be packaged into the `.intunewin` format.
4. Press the `Select Folder` button and select the output folder (This is where the `.intunewin` will be saved).
5. `Select catalog folder` text box and its respective `Select Folder` button will be disabled until you specify `Yes` or `No` using the radio buttons below.
    - If you selected `No` to the catalog folder prompt, then press the `Generate .intunewin` button.
    - if you selected `Yes` then press the `Select Folder` button and choose your catalog folder (this is used when working with Windows S Mode) Then press the `Generate .intunewin` button.

6. Celebrate, because you can now upload your .intunewin file to Intune, and you didn't have to type in those long file paths to do it.
