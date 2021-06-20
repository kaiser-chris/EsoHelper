# ESO Launcher Closer
Simple tray application that closes the Elder Scrolls Online Launcher and more.

#### Screenshot
![Example Screenshot](docs/img/Screenshot.png?raw=true)

### Features
The application supports two modes:
 * Auto Close
 * Inactive Close
 * Auto Light Attack Weaving

#### Auto Close
Closes the launcher as soon as the game is launched.

#### Inactive Close
Closes the launcher 1 minute after it was started or the game was closed.
This can be useful if you are experimenting with addons or are generally restarting the game often.

#### Auto Light Attack Weaving
When active this [script](https://github.com/256shadesofgrey/eso-light-attack-weave) (by [256shadesofgrey](https://github.com/256shadesofgrey)) will be run. The script will start **unsuspended** and can be suspended by pressing *tab*. For more information read the [documentation](https://github.com/256shadesofgrey/eso-light-attack-weave/blob/master/README.md). If you want to provide your own script or use a different configuration place your script file like this:
  * EsoLauncherCloser.exe
  * scripts
	  * eso-light-attack-weave.ahk <= Your script

### Build
 * Visual Studio 2019
 * Net Framework 4.7.2