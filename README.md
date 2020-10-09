# MoBro Monitoring C# [ModBros](https://github.com/ModBros/mobro-theme-sdk)
> A support for local themes

This application allows you to access your local MoBro server without the use of a dedicated browser.

## Why?

Why did I create this application? I bought a 7-inch screen dedicated to the monitoring of my PC, which I connected to one of the free ports of my motherboard. I began by using a dedicated browser to display the page of my local MoBro server on this screen and I was confronted with several difficulties, such as the automatic start of the browser, the opening of the single page on the server, etc. But I didn't like this solution because I had to dedicate a browser for that and mostly there was an extra button in the taskbar that was useless.
So instead of searching for hours to find a way to perfectly adjust the browser and my Windows to try to do what I wanted, I decided to develop a Windows Form by integrating the resources of a browser.

## How?

I first worked on a VB version but of course with Microsoft, even in 2020 and on Windows 10 x64, the default integration of a browser in Windows 10 uses Internet Explorer . What was (not) my surprise to see that Internet Explorer was unable to display correctly one of the themes available with the MoBro server ! So I tried an integration with the new Microsoft Edge based on Chromium, but once again I was confronted with several problems :
- I had to install a special version of Edge Chromium, Canary
- Resource usage was too high (about 10% of my CPU compared to 5 to 6% for Google Chrome)
- Even in full screen the Edge address bar remains displayed if the last known position of the mouse on this screen is in its area.

## Finally?

Finally I decided to use the Google Chrome DLLs and the CEF library. This library was easily accessible for the C# language so I thought why not, as I don't know this programming language it would be a good opportunity to get started :)

## Prerequisites

First of all, you must have the MoBro server installed on your system and have configured the theme to your convenience.
- [Mod-Bros Website](https://www.mod-bros.com/) - Get more information about the project
- [MoBro Project](https://www.mod-bros.com/en/projects/mobro) - THE CUSTOM MONITORING SCREEN WITHOUT STUPID CABLES!
- [MoBro Themes](https://www.mod-bros.com/en/forum/d/themes~820) - The themes discussion to custom your experience
- [Google Chrome](https://www.google.com/intl/en_en/chrome/) - The last version of Google Chrome (no need dev or beta version)
- Windows 10 x64 - Not tested on other Windows operating systems, but the 64-bit version is definitely needed.

## Installation

1. Download the last [available release](https://github.com/jgrunder/mobro-monitoring-cs/releases)
2. Unzip into any folder
3. Adjust the `mobro-monitoring-cs.exe.config` configuration file to your needs:
- `url`: The URL to your MoBro server (in most cases keep it to default)
- `screen_id`: ID of the screen you want to display the monitoring data (must be adapted to your system)
- `screen_width` and `screen_height`: native resolution of your screen

Please keep in mind that in this draft version there is no security yet for the data entered in the configuration file, so only enter data in the expected format otherwise the application will cause an error and stop working.

## Launch at Windows start

Go to `%appdata%\Microsoft\Windows\Start Menu\Programs\Startup` and create a shortcut that points to the file `mobro-monitoring-cs.exe`

## Contribute

Contributions are always welcome!

1. Clone/fork this repository
2. Copy and rename the `App.config.example` file into `App.config`
3. Open the file `mobro-monitoring-cs.sln` with Visual Studio 2019+ (both community and pro versions should work)
4. [Add a x64 CPU](https://www.google.com/search?q=visual+studio+add+cpu+64)
5. Generate the solution with this CPU (this will also download and install NuGet packages dependencies)

Create one pull request for one request / update / change / add

## ToDo

Everything :)
