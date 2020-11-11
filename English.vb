'Language file for seDirector
'------------------------------
'Language: English
'Last Updated: 2020-11-11
'Author: asheroto
'------------------------------

Public Class Lang
    Public Class UI
        Public Class MainWindow
            Public Shared Menu_Start = "Start"
            Public Shared Menu_Stop = "Stop"
            Public Shared Menu_Restart = "Restart"
            Public Shared Menu_Update = "Update"
            Public Shared Menu_Show_Hide = "Show/Hide"
            Public Shared Menu_Add_Server = "Add Server"
            Public Shared Menu_Delete_Server = "Delete Server"
            Public Shared Menu_Open_Game_Directory = "Open Game Directory"
            Public Shared Menu_Open_Maps_Directory = "Open Maps Directory"

            Public Shared Server_Name = "Server Name"
            Public Shared Status = "Status"
            Public Shared Uptime = "Uptime"
            Public Shared CPU = "CPU"
            Public Shared Memory = "Memory"
            Public Shared IP_Address = "IP Address"
            Public Shared Port = "Port"
            Public Shared Current_Map = "Current Map"
            Public Shared Players = "Players"
            Public Shared Game = "Game"

            Public Shared Information = "Information"
            Public Shared ServerName = "Server Name"
            Public Shared Created = "Created"

            Public Shared Events = "Events"
            Public Shared Logs = "Logs"
            Public Shared UptimeUptime = "Uptime"
            Public Shared Started = "Started"
            Public Shared Updated = "Updated"
        End Class

        Public Class ServerProperties
            Public Shared Properties_ServerName = "Server Name"
            Public Shared Properties_SRCDSLocation = "SRCDS Location"
            Public Shared Properties_Game = "Game"
            Public Shared Properties_IPAddress = "IP Address (optional)"
            Public Shared Properties_PortNumber = "Port Number"
            Public Shared Properties_ExecuteCFG = "Execute CFG"
            Public Shared Properties_Map = "Map"
            Public Shared Properties_NumberOfPlayers = "Number of Players"
            Public Shared Properties_Secure = "Secure"
            Public Shared Properties_AdditionalParameters = "Additional Parameters"
            Public Shared Properties_ProcessorAffinity = "Processor Affinity"
            Public Shared Properties_ProcessPriority = "Process Priority"
            Public Shared Properties_CommandToRun = "Command to Run"
            Public Shared Properties_ = "Properties"
            Public Shared Properties_Browse = "Browse"
            Public Shared Properties_Create = "Create"
            Public Shared Properties_CustomGameMod = "Custom Game / Mod"
            Public Shared Properties_UsePrivateIPUnlessOnDMZ = "Use private IP unless on DMZ"
            Public Shared Properties_NextAvailable = "Next Available"
            Public Shared Properties_CreateServerCFG = "Create server.cfg"
            Public Shared Properties_LocalMap = "Local Map"
            Public Shared Properties_WorkshopCustomMap = "Workshop / Custom Map"
            Public Shared Properties_UseAdditionalParametersToAdjust = "(use additional parameters to adjust)"
            Public Shared Properties_NormalRecommendedRealtimeNotRecommended = "Normal is recommended; realtime is not recommended"

            Public Shared Properties_ServerPropertiesCannotBeChangedWhileRunning = "Server Properties cannot be changed while running"
            Public Shared Properties_PleaseFillRequiredFields = "Please fill required fields"
            Public Shared Properties_SaveSettings = "Save Settings"

            Public Shared StartOptions = "Start Options"
            Public Shared StartThisServerWhenSedirectorStarts = "Start this server when seDirector starts"
            Public Shared HideServerWindow = "Hide server window"
            Public Shared HideUpdateWindow = "Hide update window"
            Public Shared UpdateOptions = "Update Options"
            Public Shared ValidateUpdate = "Validate Update Every Time (adds the -validate parameter to SteamCMD)"
            Public Shared ValidateUpdateUse = "Use this if your servers aren't updating or working properly."
            Public Shared UpdateAutoCurMapCurPlayers = "Update Automatically, Current Map, Current Players"
            Public Shared SaveAndReopen = "Save and reopen to change these settings"
            Public Shared PluginDescription = "seDirector can update your server automatically when Steam's content servers change. For these features to work, you must have SourceMod installed prior to installing this plugin (except if game server is Garry's Mod)."
            Public Shared PluginDescription2 = "The seDirector plugin also updates the 'Current Map' and 'Players' columns on the server list."
            Public Shared UpdateAuto = "Update Automatically"
            Public Shared SpecialCSGO = "Special Instructions for CSGO Servers"
            Public Shared PluginStatus = "Plugin Status"
            Public Shared Installed = "Installed"
            Public Shared NotInstalled = "Not Installed"
            Public Shared Install = "Install"
            Public Shared Uninstall = "Uninstall"
            Public Shared Directory = "Directory"
            Public Shared CrashRecovery = "Crash Recovery"
            Public Shared RecoverFromServerCrash = "Recover from server crash"
            Public Shared HowCrashRecoveryWorks = "How crash recovery works"
            Public Shared CrashRecovery1 = "seDirector keeps count of how many times a server has crashed.  If a server has crashed 2 times in 10 minutes, seDirector will automatically try to update the server.  If the server crashes again within 10 minutes after the update, seDirector will stop the server.  If a server has gone more than 10 minutes without crashing, the crash counter will reset."
            Public Shared CrashRecovery2 = "1 crash in 10 minutes = okay"
            Public Shared CrashRecovery3 = "2 crashes in 10 minutes = attempt to update"
            Public Shared CrashRecovery4 = "1 crash in 10 minutes after updating = server will stop (notification sent if enabled)"
            Public Shared CrashRecovery5 = "Every 10 minutes without a crash = count resets"

            Public Shared AddonsFolder = "Addons Folder"
            Public Shared NotSet = "not set"
            Public Shared MoreInfo = "More Info"
            Public Shared Name = "Name"
            Public Shared YourVersion = "Your Version"
            Public Shared LatestVersion = "Latest Version"
            Public Shared Path = "Path"
            Public Shared SaveAndReopenToChange = "Save and reopen to change these settings"
            Public Shared AddonsNotSupported = "Addons not supported in this game server"
            Public Shared Actions = "Actions"
            Public Shared AddOn = "Add-on"
            Public Shared VersionToInstall = "Version to Install"
            Public Shared InstallChange = "Install/Change"
            Public Shared Publisher = "Publisher"
            Public Shared Description = "Description"
            Public Shared Website = "Website"
            Public Shared Documentation = "Documentation"
            Public Shared Forum = "Forum"
            Public Shared PluginsAddons = "Plugins/Addons"
            Public Shared AndAnd = "and"
            Public Shared NoAvailableAddonsToInstall = "No available addons to install."

            Public Shared WhenWhen = "When"
            Public Shared Action = "Action"
            Public Shared Daily = "Daily"
            Public Shared Weekly = "Weekly"
            Public Shared Monthly = "Monthly"
            Public Shared OnAnEvent = "On an Event"
            Public Shared Hour = "Hour"
            Public Shared Minute = "Minute"
            Public Shared Crashes = "Crashes"
            Public Shared UpdateComplete = "Update Complete"
            Public Shared SaveTask = "Save Task"
            Public Shared Cancel = "Cancel"
            Public Shared RestartServer = "Restart Server"
            Public Shared RestartServer2 = "Restart Server w/In-Game Notification (Plugin Required)"
            Public Shared UpdateServer = "Update Server"
            Public Shared UpdateServer2 = "Update Server w/In-Game Notification (Plugin Required)"

            Public Shared TextOrCFGFile = "Text or CFG File"
            Public Shared BZ2Compression = "BZ2 Compression"
            Public Shared BZ2CompressionExplained = "BZ2 compression allows content to be downloaded to a player's computer much faster than downloading the traditional BSP files.  It is similar to a ZIP file except it ends in BZ2.  The files are created in the same directory as the content."
            Public Shared AutoCompressUncompressed = "Automatically compress uncompressed content on server start"
            Public Shared WhatToCompress = "What to Compress"
            Public Shared HTTPFastDownload = "HTTP Fast Download"
            Public Shared HTTPFastDownloadExplained = "You may enable Directory Synchronization and/or FTP/SFTP Synchronization so that your content is automatically updated on your web server every time this server is started. Sync works by mirroring the maps, sound, materials, model, and resource directories. If target directories already exist they will be updated to match this server's content. Only BZ2 files will be synced."
            Public Shared HTTPFastDownloadExplained2 = "Create a new, empty directory on your web server and specify its location below."
            Public Shared DirSyncHTTP = "Directory Synchronization for HTTP Fast Download"
            Public Shared DirSyncHTTP2 = "Enable Directory Synchronization"
            Public Shared DirSyncHTTP3 = "Generally used if your web server is on the same computer as your game server(s)"
            Public Shared TargetDirectory = "Target Directory"
            Public Shared FTPSFTPSync = "FTP/SFTP Synchronization for HTTP Fast Download"
            Public Shared EnableFTPSFTP = "Enable FTP/SFTP Synchronization"
            Public Shared Server = "Server"
            Public Shared Username = "Username"
            Public Shared Password = "Password"
            Public Shared ConnectionType = "Connection Type"
            Public Shared Port = "Port"
            Public Shared RemoteDir = "Remote Directory"
            Public Shared SFTPRecommended = "SFTP is recommended because it encrypts your credentials"
            Public Shared TestCon = "Test Connection"

            Public Shared ExampleNotification = "Example Notification"
            Public Shared ExampleNotification_Subject = "Subject"
            Public Shared ExampleNotification_SubjectData = "seDirector Alert: Server <ServerName>"
            Public Shared ExampleNotification_Body = "Body"
            Public Shared ExampleNotification_BodyData = "Server <ServerName> has crashed and seDirector is unable to recover it automatically."
            Public Shared EmailTextSMS = "E-mail/Text/SMS Notifications"
            Public Shared EmailTextSMS2 = "seDirector will automatically notify you via e-mail if your server crashes and is unable to be recovered automatically OR if a server fails to start successfully.  The 'Recover from server crash' checkbox on the Automation tab MUST be checked in order for e-mail notifications to work."
            Public Shared EnableEmailNotifications = "Enable E-mail Notifications"
            Public Shared WantToReceive = "Want to receive a text/SMS?"
            Public Shared CopyFromOtherServer = "Copy From Other Server"
            Public Shared SendTestEmail = "Send Test E-mail"
            Public Shared DiscordNotifications = "Discord Notifications"
            Public Shared DiscordNotifications2 = "seDirector will automatically notify you via Discord if your server crashes and is unable to be recovered automatically OR if a server fails to start successfully.  The 'Recover from server crash' checkbox on the Automation tab MUST be checked in order for Discord notifications to work."
            Public Shared EnableDiscordNotifications = "Enable Discord Notifications"
            Public Shared DiscordWebhook = "Discord Webhook"
            Public Shared HowDoI = "How do I get a webhook?"
            Public Shared SendTestNotif = "Send Test Notification"
        End Class

        Public Class Options
            Public Shared Application = "Application"
            Public Shared Language = "Language"
            Public Shared HelpTranslate = "Help Translate seDirector!"
            Public Shared SOWS = "Start on Windows startup"
            Public Shared MTSTOC = "Minimize to system tray on close"
            Public Shared DNCCP = "Do not check for current players and current map"
            Public Shared DNAU = "Do not automatically update seDirector"
            Public Shared CDS = "Create desktop shortcut for seDirector"
            Public Shared RecommendedFolder = "Click Here for the Recommended Folder Structure to Use With seDirector"
            Public Shared DDTB = "Default Directory to Browse"
            Public Shared Browse = "Browse"
            Public Shared MoreInfo = "More Info"
            Public Shared SUT = "Server Update Tool"
            Public Shared SCL = "SteamCMD location"
            Public Shared Clear = "Clear"
            Public Shared Download = "Download"
            Public Shared SteamLogin = "Steam Login"
            Public Shared SteamLoginDesc = "Optional.  Only required for some games or if you are doing something advanced."
            Public Shared Username = "Username"
            Public Shared Password = "Password"
        End Class

        Public Class CreateServer
            Public Shared Game = "Game"
            Public Shared ITD = "Instal to Directory"
            Public Shared Browse = "Browse"
            Public Shared CreateServer = "Create Server"
        End Class
    End Class

    Public Class Controller
        Public Shared PreviouslyUsedSedirector = "Have you previously used seDirector on this computer?"
        Public Shared PleaseSelectPreviousSedirector = "Please select the previous version of seDirector so your data can be upgraded."
        Public Shared SelectPreviousVersionOfSedirector = "Select previous version of seDirector"
        Public Shared XMLFileNotExist = "{0} does not exist in the location you specified. Please make sure {0} is in the same directory as seDirector and try again."
        Public Shared DataUpgradeSuccess = "Data upgraded successfully. Please relaunch seDirector."
        Public Shared ErrorMovingFilesManuallyMove = "There was an error moving one or more of the files. Please manually move Servers.xml and Settings.xml to the following directory, then restart seDirector."
    End Class

    Public Class CreateServer
        Public Shared SelectEmptyDirectoryForServer = "Select an EMPTY directory to install the server.  Make a new directory if needed."
        Public Shared CannotUseRootDirectoryDrive = "You cannot use the root directory of a drive."
        Public Shared DirectoryNotEmptyOverwrite = "Directory is not empty. Files may be overwritten! Proceed?"
        Public Shared UserPassReqToUpdate = "A username and password for Steam is required to update this game. Please set it in Tools->Options and return to this window."
    End Class

    Public Class FTP
        Public Shared CouldNotConnectServer = "Could not connect to server. Check the server, port, username, password, and connection type."
        Public Shared CouldNotRetrieveDirectoryContents = "Could not retrieve directory contents."
        Public Shared CouldNotWriteTestFile = "Could not write test file. Please check for write access to this directory."
        Public Shared CouldNotDeleteTestFile = "Could not delete test file. Please check for delete access to this directory."
        Public Shared FTPSFTPSync = "FTP/SFTP Sync"
        Public Shared FTPSFTPSyncInProgress = "FTP/SFTP sync in progress... This may take several minutes..."
        Public Shared InvalidUserPass = "Invalid username or password."
        Public Shared ErrorInitializingSFTP = "Error initializing SFTP subsystem"
        Public Shared CouldNotReadDirectoryContents = "Could not read directory contents. Check for read access to this directory."
        Public Shared ErrorWhileReadingDirectoryContents = "Error while reading directory contents."
        Public Shared NoItemsFoundInDirectory = "No items found in this directory."
        Public Shared CouldNotOpenTestFileForWriting = "Could not open test file for writing. Please check for write access to this folder."
    End Class

    Public Class GameCommon
        Public Shared UpdatedPlugin = "Updated plugin"
    End Class

    Public Class Networking
        Public Shared Downloading = "Downloading"
        Public Shared DownloadingX = "Downloading {0}"
        Public Shared ErrorWhileDownloadingFile = "There was an error while trying to download a file."
        Public Shared Extracting = "Extracting"
        Public Shared ExtractingX = "Extracting {0}"
        Public Shared SteamCMDNeedsUpdate = "SteamCMD has been downloaded and needs to update for the first time. The next window will close automatically when finished, please do not close out of it manually."
        Public Shared ErrorWhileTryingToExtract = "There was an error while trying to extract."
    End Class

    Public Class Options
        Public Shared DesktopShortcutSuccess = "Desktop shortcut success"
        Public Shared DesktopShortcutError = "Desktop shortcut error"
        Public Shared DefaultDirectory = "Default directory"
        Public Shared SelectEmptyDirForSteamCMD = "Select an empty directory to install SteamCMD. Make a new directory if needed."
        Public Shared DirNotEmptyOverwrite = "Directory is not empty. Files may be overwritten! Proceed?"
        Public Shared ErrorTryingDownload = "Error while trying to download {0}. Internet connection issue?"
        Public Shared SelectDirMostCommonUsed = "Select the directory you most commonly use in seDirector."
        Public Shared UnsureCreateDir = "Unsure? Create a directory under C:\ called Steam and select it."
        Public Shared DefaultDirToBrowse = "The 'Default Directory to Browse' setting tells seDirector to automatically open to the specified directory automatically when browsing for a file or folder. That way you don't have to go through Computer->C Drive->Steam->etc every time, it will automatically open to the directory you set it to."
    End Class

    Public Class Progress
        Public Shared CancelCurrentDownload = "Cancel the current download?"
        Public Shared CancelExtractOp = "Cancel the extract operation?"
        Public Shared CancelCurrentBackup = "Cancel the current backup operation?"
        Public Shared CancelBZ2Compression = "Cancel BZ2 compression?  All files will be recompressed the next time you start the server."
        Public Shared CancelFTPSync = "Cancel FTP synchronization?  Some files may be partially uploaded.  Resyncing will resolve partial uploads."
        Public Shared CancelLocalSync = "Cancel local directory synchronization?  Some files may be partially copied.  Resyncing will resolve partial files."
        Public Shared CancelDirectoryDuplication = "Cancel server directory duplication?"
    End Class

    Public Class ServerConfig
        Public Shared CouldNotDetectSteamInf = "Couldn't detect steam.inf in game directory. Please open Properties and select srcds.exe again. If the problem persists, turn on the -validate update option in properties and update, then turn it back off."
        Public Shared CouldNotLocateSteamInf = "Could not locate steam.inf in game directory."
        Public Shared ThisServerFailedToStartSuccessfully = "This server failed to start successfully."
        Public Shared ErrorLoadingServersXML = "There was an error loading the Servers.xml data file. This could be caused by a bug in seDirector. If Servers.xml is empty, delete the file and either restore it from a backup or add your servers back to seDirector manually. Please email support@sedirector.net and let us know what you were doing in seDirector right before this happened. Attach Servers.xml to your email if it is NOT empty."
    End Class

    Public Class SupportRequest
        Public Shared PleaseEnterEmail = "Please enter a valid e-mail address."
        Public Shared ErrorSendingRequest = "There was an error sending your request. Check your Internet connection or e-mail support@sedirector.net if the problem continues."
        Public Shared MessageSent = "Your message has been sent. Please allow 1 to 2 business days for a reply. Thank you."
        Public Shared ErrorSendingInformation = "There was an error sending the information. Check your Internet connection and contact support@sedirector.net if the problem persists."
    End Class

    Public Class Status
        'Text for statuses
        Public Shared Running = "Running"
        Public Shared Offline = "Offline"
        Public Shared Starting = "Starting"
        Public Shared Stopping = "Stopping"
        Public Shared ErrorStarting = "Error Starting"
        Public Shared ErrorStopping = "Error Stopping"
        Public Shared UpdateStarting = "Update Starting"
        Public Shared Updating = "Updating"
        Public Shared UpdateError = "Update Error"
        Public Shared PendingRestart = "Pending Restart"
        Public Shared PendingUpdate = "Pending Update"
    End Class

    Public Class MainWindow
        'Text for the main window
        Public Shared AllHosts = "All Hosts"

        Public Shared Uptime = "Uptime"
        Public Shared Started = "Started"
        Public Shared LastUpdated = "Last Updated"

        Public Shared TheMaxNumberOfServers = "The maximum number of servers is {0}."

        Public Shared StartingMap = "Starting Map"
        Public Shared CurrentMap = "Current Map"

        Public Shared ServerCrashedEvenAfterUpdating = "Server crashed even after updating"
        Public Shared SentServerCrashEmail = "Sent server crash e-mail notification"
        Public Shared SentServerCrashDiscord = "Sent server crash Discord notification"

        Public Shared ZipFiles = "Zip Files"
        Public Shared Backup = "Backup"

        Public Shared ErrorCheckingNewerVersionSedirector = "Error 1007: Error checking for newer version of seDirector. Check your Internet connection and try again or contact seDirector support if the problem persists."

        Public Shared TaskRequestedServerRestart = "Task requested server restart."
        Public Shared TaskRequestedServerRestartInGame = "Task requested server restart w/in-game notification"
        Public Shared RestartServer = "Restart Server"
        Public Shared RestartServerInGame = "Restart Server w/In-Game Notification (Plugin Required)"

        Public Shared Daily = "Daily"
        Public Shared Weekly = "Weekly"
        Public Shared Monthly = "Monthly"

        Public Shared UpdateServer = "Update Server"
        Public Shared UpdateServerInGame = "Update Server w/In-Game Notification (Plugin Required)"
        Public Shared TaskRequestedUpdateInGame = "Task requested server update w/in-game notification"
        Public Shared Detected = "Detected"
        Public Shared ServerBZ2CompCanceled = "Server BZ2 compression cancelled"
        Public Shared ServerLocalDirSyncCanceled = "Server local directory sync cancelled"
        Public Shared ServerFTPCanceled = "Server FTP/SFTP sync cancelled"
        Public Shared SedirectorAlert = "seDirector Alert"
        Public Shared Server = "Server"
        Public Shared ServerCrashedUnableToRecoverAuto = "Server {0} has crashed and seDirector is unable to recover it automatically."
        Public Shared ErrorSendingTestEmailContact = "Error sending test e-mail. Contact seDirector support."
        Public Shared DiscordNotificationSent = "Discord notification sent."
        Public Shared ErrorSendingDiscordNotification = "Error sending Discord notification. Confirm that your webhook URL Is correct And try again. If the problem persists, contact seDirector support."
        Public Shared LocalDirSync = "Local Directory Sync"
        Public Shared LocalDirSyncInProgress = "Local directory sync in progress... This may take several minutes..."
        Public Shared DoDuplicateGameDir = "Do you want to duplicate the game server's directory contents?"
        Public Shared SelectEmptyDir = "Select an EMPTY directory to copy the server's folder contents. Make a new directory if needed."
        Public Shared CannotUseRootDir = "You cannot use the root directory of a drive."
        Public Shared DirNotEmpty = "Directory is not empty. Please choose an empty directory to place the server's folder contents."
        Public Shared CopyingGameSerDirCont = "Copying game server directory..."
        Public Shared CopyingGameSerDir = "Copying game server directory..."
        Public Shared Calculating = "Calculating"
        Public Shared ErrorDuringServerDup = "Error during server duplication"
        Public Shared RecommendedFolderStruc = "Recommended Folder Structure"
        Public Shared DonateToSedirector = "Donate to seDirector"
    End Class

    Public Class URLs
        Public Shared UpdateUrl = "https//api.sedirector.net/update"
        Public Shared ReleaseNotesUrl = "https//api.sedirector.net/release-notes/"

        Public Shared AutomaticUpdateMoreInfoUrl = "https//sedirector.net"
        Public Shared seDirectorURL = "https//sedirector.net"

        Public Shared SteamTools = "http//forums.alliedmods.net/showthread.php?t=129763"
        Public Shared SourceMod = "http//www.sourcemod.net"

        Public Shared seDirector_Support = "https//sedirector.net"

        Public Shared SteamCMD_URL = "http//media.steampowered.com/installer/steamcmd.zip"

        Public Shared AddonListUrl = "https//api.sedirector.net/addons/"

        Public Shared HTTPFastDownload_URL = "https//support.steampowered.com/kb_article.php?ref=9717-HMAP-7066"
    End Class

    Public Class Notifications
        'Text for notifications
        Public Shared DebugModeEnabled = "Debug mode Is enabled!"
        Public Shared RunningNotAttached = "{0} Is running And Is Not attached to seDirector. Click OK to terminate the process Or cancel to exit seDirector."
        Public Shared ForceUpdateSedirector = "Force update seDirector?"
        Public Shared DesktopShortcutCreated = "Desktop shortcut created."
        Public Shared DesktopShortcutError = "There was an error creating the shortcut. Please make sure you have access to the desktop. Check the log file for more information."
        Public Shared SteamUsernamePasswordChanged = "The Steam username Or password has changed. Please enter the Steam Guard code (sent to your e-mail) on the following window if asked. Do Not close out of the next window, let it close automatically. If you mess up, just press backspace to correct." + vbCrLf + vbCrLf + "If you need the code to be sent again, press Ctrl-C one time And let it close automatically, set your username to something else, Save, then change it back to the correct value, Save."
        Public Shared CannotUseRootDirectoryOfDrive = "You cannot use the root directory of a drive."
        Public Shared PleaseSelectSrcdsInGameDirectory = "Please select srcds.exe in the game's directory."
        Public Shared ErrorStartingServer = "Error starting server"
        Public Shared MaxStartAttemptsReached = "Cannot start after {0} attempts. User required."
        Public Shared MaxCrashesOccurred = "Server crashed {0} times in a row. User required."
        Public Shared NoCrashesInTenMinutes = "No crashes in 10 minutes"
        Public Shared SecondCrashInTenMinutesUpdating = "2nd crash in 10 minutes - attempting to update server"
        Public Shared ErrorServerRecommendation = "Run an update on the server to see if that fixes the problem.  If that does not fix it there may be a problem with an addon or plugin.  Check the server's error logs for more information."
        Public Shared CrashedByClosing = "Crashed by closing"
        Public Shared DetectedNotResponding = "Detected not responding, retrying in 10 seconds"
        Public Shared CrashByNotResponding = "Crashed by not responding"
        Public Shared ManualInterventionRequired = "Manual intervention required"
        Public Shared DetectedUpdate = "Detected update request"
        Public Shared DetectedRestartRequest = "Detected restart request"
        Public Shared ServerStoppedForUpdating = "Server stopped for updating"
        Public Shared ServerStoppedForPendingRestart = "Server stopped for pending restart"
        Public Shared UpdateComplete = "Update complete"
        Public Shared AreYouSureTerminate = "Are you sure you want to terminate all instances of {0}.exe?"
        Public Shared AllInstancesOf = "All instances of {0}.exe have been terminated if they existed."
        Public Shared QuitConfirm = "There are servers running or updating.  If you exit, all servers will be stopped. Are you sure you want to exit?"
        Public Shared ErrorStartingServerRecommendation = "Error 1009: There was an error starting {0}.  Make sure the port you are using is an available port (one port per server per host) and that the IP address is valid.  If you still experience problems, try updating the server or running the server manually to correct the problem.  Sometimes a lower version of SourceMod or Metamod is required in order to run the game."
        Public Shared ErrorStartingUpdateRecommendation = "Error 1010: There was an error starting an update on server {0}. We've found the most common problem is that the " + Chr(34) + "Automatically detect settings" + Chr(34) + " checkbox is unchecked in Internet Options->Connections->LAN Settings. If it is checked, redownload {1}. Launch {1} through a command prompt for more information. Sometimes a lower version of SourceMod or Metamod is required in order to run the game." + vbCrLf + vbCrLf + "Here's the {1} command line w/arguments:" + vbCrLf + vbCrLf + "{1}.exe {2}"
        Public Shared QuitServerForUpdateConfirmation = "Server {0} is currently running." + vbCrLf + vbCrLf + "Do you want to stop the server to proceed with updating?"
        Public Shared DeleteServerConfirmation = "Are you sure you want to delete server {0}?"
        Public Shared EmailInfo = "If e-mail alerts are enabled on a server, you'll receive alerts from alerts@sedirector.com automatically. No need to bother with SMTP settings - e-mail notifications are included as part of your seDirector account."
        Public Shared BetaNotice = "You are running a {0} version of seDirector that will expire in {1} days." & vbCrLf & vbCrLf & "Would you like to sign up for the mailing list to be notified when stable releases are available?"
        Public Shared BetaExpired = "This version of seDirector has expired. Press OK to go to AsherSoftware.com for an updated version."
        Public Shared BetaNotificationText = "{0} version - NOT a stable release - some features disabled"
        Public Shared NoAvailableUpdates = "No available updates at this time."
        Public Shared DotNetFrameworkNeeded = "You must have .NET Framework 4.5 or higher to run seDirector." & vbCrLf & vbCrLf & "Press OK to open the .NET Framework download page."
        Public Shared NewerVersionAvailable = "A newer version of seDirector is available." & vbCrLf & vbCrLf & "Current Version: {0}" & vbCrLf & "New Version: {1}" & vbCrLf & vbCrLf & "Would you like to update seDirector?  Your servers will continue to run during the seDirector update process."
        Public Shared AutomaticUpdateInfo = "seDirector supports the ability to update a server automatically when Steam's servers have an update available. For this to work you must have SourceMod installed with the SteamTools extension and the seDirector plugin." & vbCrLf & vbCrLf & "Press OK to open the seDirector plugin page."
        Public Shared FileDoesNotExist = "{0} does not exist in the specified location."
        Public Shared GameServerDirectoryMissing = "The game directory for server {0} is missing.  Please select srcds.exe again."
        Public Shared CreateServerConfirm = "Create {0} in {1}?"
        Public Shared UpdateToolMissing = "{0} is missing.  Please go to Tools->Options to set the location of {0}."
        Public Shared UpdateToolNotSelected = "An update tool has not been selected for {0}.  Please go to the Automation tab in the server's properties to select an update tool."
        Public Shared ServerBeingCreated = "The server is now being created.  Please wait until the updater/installer has finished, then select srcds.exe in the server properties window."
        Public Shared DownloadingUpdateTool = "Click OK to download {0}.  After the download is complete, extract the exe from the zip file and place an the appropriate directory, then come back to this screen."
        Public Shared NoUpdateToolSet = "An update tool has not been set on {0} of your servers.  Please set the update tool in the Automation tab of the server's properties."
        Public Shared ShuttingDownProper = "Shutting Down"
        Public Shared ShuttingDown = "Shutting down"
        Public Shared AddonUpdateFailure = "Error 1011: Error when trying to download the addon lists. Check your Internet connection or contact seDirector support if this issue continue."
    End Class

    Public Class Backups
        Public Shared CreateBackupAsk = "Create backup for server {0}?"
        Public Shared CreatingBackupCaption = "Creating Backup"
        Public Shared BackingUpServer = "Backing up {0}"
    End Class

    Public Class Compressing
        Public Shared CompressingToBZ2 = "Compressing to BZ2"
        Public Shared CompressingXToBZ2 = "Compressing {0} to BZ2..."
        Public Shared RecompressingDueToCancel = "(recompressing all due to previous cancellation)"
    End Class

    Public Class LogsLogs
        Public Shared CompressLogsAsk = "Compress the logs for server {0}?"
        Public Shared LogsDirectoryDNE = "Logs directory does not exist!"
        Public Shared CompressingLogsCaption = "Compressing Logs"
        Public Shared CompressingLogsDescription = "Compressing logs {0}"
    End Class

    Public Class Errors
        Public Shared ErrorCreatingServer = "Error 1012: There's a problem with {0}. We've found the most common problem is that the " + Chr(34) + "Automatically detect settings" + Chr(34) + " checkbox is unchecked in Internet Options->Connections->LAN Settings. If it is checked, redownload {0}. Launch {0} through a command prompt for more information."
    End Class

    Public Class Crashes
        Public Shared NegativeMemory = "Crashed by negative memory (not responding?)"
    End Class

    Public Class ServerProperties
        Public Shared Addons = "Addons"
        Public Shared CopyOf = "Copy of"

        Public Shared MetamodSource = "Metamod:Source is a C++ plugin environment for Half-Life 2. It acts as a 'metamod' which sits in between the Game and the Engine, and allows plugins to intercept calls that flow between. It provides a mechanism called SourceHook, a very powerful library for intercepting, overridding, and superseding virtual function calls."
        Public Shared SourceMod = "SourceMod is server modification for any game that runs on the Half-Life 2 engine. It is a powerful, highly optimized platform for scripting plugins and handling server administration. The default package comes with a base set of plugins, but there are over 2,500 plugins in the community."
        Public Shared VersionListEmpty = "The {0} version list is empty. Do you want to update the list of versions for all addons?"
        Public Shared ErrorInstallingAddon = "Error installing addon. Check your Internet connection and try again."

        Public Shared TaskConfirm = "Are you sure you want to remove task {0}?"

        Public Shared RemovingMetamodAffectSourcemod = "Removing Metamod will stop SourceMod from working. You must remove SourceMod first."
        Public Shared RemoveXFromServer = "Remove {0} from this server?"
        Public Shared WarningAllDataDeleted = "WARNING: All add-on data will be deleted."
        Public Shared AddonCouldNotBeDetected = "Addon could not be detected. Make sure you have permission to write to {0} and rerun the Install/Change process."
        Public Shared DoesNotExistClick = "Does not exist. Click here to create it."

        Public Shared SaveChangesFile = "Save changes to file?"
        Public Shared ProblemFileNotExist = "Problem opening file. File does not exist."
        Public Shared CouldNotSaveFile = "Could not save file"

        Public Shared YouShouldCreateDirUnique = "You should create a directory on your web server unique to this game server."
        Public Shared Example = "Example"
        Public Shared URL = "URL"
        Public Shared RemoteDir = "Remote Directory"

        Public Shared Connecting = "Connecting"

        Public Shared AllTestsPassedFTP = "All tests passed. FTP/SFTP synchronization should work."
        Public Shared OneMoreTestFailedFTP = "One or more tests failed. FTP/SFTP synchronization won't work until the previous errors are resolved."
        Public Shared ErrorTestingFTP = "There was an error testing the FTP/SFTP connection. Please make sure all fields are filled out properly."
        Public Shared TestCon = "Test Connection"
        Public Shared ForExample = "For example:"
        Public Shared SpecialInstructionsCSGO = "Special Instructions for CSGO"
        Public Shared PluginRequired = "Plugin Required"

        'The use of the below three variables is as specified in the last variable
        Public Shared SpecifyExactPath = "Specify the exact path to the game directory directory that contains the maps, sound, etc, subdirectory."
        Public Shared WouldBeAccessibleAt = "would be accessible via HTTP at"
        Public Shared UseTestConnection = "Use the Test Connection button to ensure you can connect and that you have specified the correct directory."
        Public Shared SWU_EXAMPLE = Lang.ServerProperties.SpecifyExactPath & vbNewLine & vbNewLine & Lang.ServerProperties.ForExample & vbNewLine & "/var/www/yourdomain.com/assets/tf2" & vbNewLine & Lang.ServerProperties.WouldBeAccessibleAt & vbNewLine & "http://yourdomain.com/assets/tf2/" & vbNewLine & vbNewLine & Lang.ServerProperties.UseTestConnection

        Public Shared CSGO_Plugin_Info = "<p>With CSGO, the server hibernates before the seDirector plugin has a chance to turn that off. You must set <strong>sv_hibernate_when_empty</strong> to <strong>0</strong> in your cfg file that starts the server, otherwise the seDirector plugin will NOT work.</p> <p> <strong>If you don't set this cvar to 0:</strong><br> (1) Updates will not occur until a player joins<br> (2) After players are notified in-game of a server update, if all leave before the countdown reaches 0, your server will never update<br> (3) Because of 1+2, this causes an endless loop of in-game updates and thus an outdated server </p> <p>You <i>cannot</i> simply turn off hibernation later, it must be done in the cfg file that launches when your server runs.</p> <p><strong>Add this line to your cfg file and make sure it's not anywhere else:</strong><br> sv_hibernate_when_empty 0 </p>"
        Public Shared AddonInfo = "Addon Info"
        Public Shared AddonInfoInfo = "<h3>General</h3><p>seDirector supports installing, upgrading, downgrading, reinstalling, and removing addons. seDirector is smart when changing the addons; it will only install the files necessary to change the versions - it will not remove your cfg files or extensions. </p> <p> <h3>Automatic Backup</h3> If an addon is upgraded, downgraded, or reinstalled, a backup will be made prior to taking any action. Look under the addons\[Backups] directory for the backups created by seDirector. </p> <p><h3>Testing</h3> <b>MAKE SURE to test your server after making addon changes.</b> Type 'meta version' in console to make sure <b>Metamod:Source</b> is working. Type 'sm version' in console to make sure <b>SourceMod</b> is working. If you receive an error message after an update has been installed/changed, make sure you're using the latest version. Older versions may not work properly and cause your server to crash or plugins to malfunction. </p> <p> <h3>Other</h3> <b>SourceMod</b> depends on <b>Metamod:Source</b> to work. Make sure to use a version of <b>SourceMod</b> compatible with your version of <b>Metamod:Source</b>. After installing <b>Metamod:Source</b>, the metamod.vdf file is automatically generated specific to your game server. </p>"

        Public Shared YouHaveSelectedActionSedirectorPlugin = "You've selected an action that can only be used if the seDirector plugin is installed. Please make sure to install this before you save the task, otherwise you will run into issues."

        Public Shared SelectDestinationDirSync = "Select the destination directory for directory synchronization"
        Public Shared UseFormatBelowNotifEmail = "Use the format below as your notification e-mail address."
        Public Shared PleaseEnterServerNameProp = "Please enter a server name in the Properties tab before testing notifications."
        Public Shared PleaseEnterEmailAddressTesting = "Please enter an e-mail address before testing notifications."
        Public Shared PleaseCheckDiscordWebhook = "Please check the Discord webhook URL and try again."
        Public Shared DiscordWebhookMoreInfo = "A Discord webhook is required in order for this to work. If you don't already have a Discord server for these notifications, create a new Discord server. Once created, go into the Discord server (or channel) settings, click on Integrations, and click 'New Webhook'. Copy the webhook URL and paste it into seDirector."

        Public Shared ServerCfgAlreadyExist = "Server.cfg already exists in this game's cfg directory, do you want to save it as server.cfg.example instead?"

        Public Shared WindowCaptionNewServer = "New Server"
        Public Shared WindowCaptionServer = "{0} - Properties"
        Public Shared PluginSuccessfullyInstalled = "Plugin successfully installed."
        Public Shared ErrorInstallingPlugin = "Error 1007: Error installing plugin. Please make sure you have access to the plugins directory."
        Public Shared PluginSuccessfullyRemoved = "Plugin successfully removed."
        Public Shared ErrorRemovingPlugin = "Error 1008: Error removing plugin. Please make sure no other programs are using this plugin. Close out of any Windows Explorer instances you may have open. Restart the computer if necessary."

        Public Shared PortNotAllowed = "{0} port not allowed"
        Public Shared PortAssignedToAnotherServer = "Port assigned to another server"

        Public Shared AnotherPropertiesWindowOpen = "Another properties window is already open.  Please close the other window before opening a new one."
        Public Shared AllProcessors = "All Processors"

        Public Shared Installed = "Installed"
        Public Shared NotInstalled = "Not Installed"

        Public Shared NotTheUpdateTool = "You can choose {0} as the update tool, however, {1} is the standard update tool for {2}.  Updating with {0} is not officially supported and may not work properly." + vbCrLf + vbCrLf + "Do you still want to save this configuration?"
        Public Shared AnUpdateToolHasNotBeenSelected = "An update tool has not been selected.  {0} is the default tool for {1}, would you like to update using that?"
        Public Shared SwitchingToSteamCMD = "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + vbCrLf + "IMPORTANT" + vbCrLf + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + vbCrLf + vbCrLf + "You are switching to SteamCMD from HLDSUpdateTool using the same directory.  SteamCMD WILL OVERWRITE ALL FILES in the game directory the first time it is used.  It is recommended that you create a new server and copy the files you need into the new directory to avoid issues.  Please make sure to BACK UP your game server before proceeding."

        Public Shared SrcdsGameDirectoryInUse = "This srcds.exe game directory is already in use by server {0}. Please create a new directory for a new server. Each game server much have its own directory."
        Public Shared CouldNotDetectGameServer = "Could not detect the game server. Please make sure the game is supported by seDirector and that the game server directory contains all the necessary files needed to run the game server."
        Public Shared DirectorySyncFieldMissing = "Enable Directory Sync is checked but there's a field missing information. Check the fields in the middle of the Optimization tab."
        Public Shared FTPSyncFieldMissing = "Enable FTP Synchronization is checked but there's a field missing information. Check the fields at the bottom of the Optimization tab."
        Public Shared FillInEmailNotification = "Please fill in the notification e-mail address or uncheck the 'Enable E-mail Notifications' checkbox."
        Public Shared FillInDiscordNotification = "Please fill in the Discord webhook or uncheck the 'Enable Discord Notifications' checkbox."
        Public Shared GameRequiresLoginToUpdate = "This game requires a login to update it. Please set the Steam login in Tools->Options or updating will fail."
        Public Shared InstallMetamodSourcemodBeforePlugin = "You must install Metamod + SourceMod before installing the seDirector plugin."

        Public Class ProcessPriority
            Public Shared Realtime = "Realtime"
            Public Shared High = "High"
            Public Shared AboveNormal = "Above normal"
            Public Shared Normal = "Normal"
            Public Shared BelowNormal = "Below normal"
            Public Shared Low = "Low"
        End Class

        Public Class Logs_ServerProperties
            Public Shared ModifiedServerProperties = "Modified server properties"
        End Class
    End Class

    Public Class UpdateProgress
        'Text for the progress of an update
        Public Shared StartUpdate = "StartUpdate"
        Public Shared Working = "Working"
        Public Shared UpdateComplete = "UpdateComplete"
        Public Shared Manual = "Manual"
    End Class

    Public Class Logs
        Public Shared StartServerBegin = "Starting server"
        Public Shared StartServerStartingError = "Starting server starting error"
        Public Shared StartServerFinished = "Running"
        Public Shared StartServerError = "Starting server error"

        Public Shared StopServerBegin = "Stopping server"
        Public Shared StopServerFinished = "Stopped"
        Public Shared StopServerError = "Stopping server error"

        Public Shared RestartServerBegin = "Restarting server"
        Public Shared RestartServerFinished = "Restarted"
        Public Shared RestartServerError = "Restarting server error"

        Public Shared UpdateServerBegin = "Started update process"
        Public Shared UpdateServerStartSuccess = "Updating server"
        Public Shared UpdateServerErrorExited = "Updating server error (exited)"
        Public Shared UpdateServerError = "Updating server error"

        Public Shared ShowHideError = "Show/Hide error"

        Public Shared CannotStartServerMissingDirectory = "Cannot start: Server directory missing"
    End Class

    Public Class FileProperties

        Public Class Logs_FileProperties
            Public Shared Title = "seDirector Log File"
            Public Shared Description = "Server log in chronological order."
            Public Shared Format = "MM/DD/YYYY HH:MM:SS AP | Event"
            Public Shared DescriptionFormat = "{0}: {1}"
            Public Shared DescriptionLabel = "Description"
            Public Shared ServerName = "Server Name"
            Public Shared ServerNameFormat = "{0}: {1}"
            Public Shared Game = "Game"
            Public Shared GameFormat = "{0}: {1}"
        End Class

    End Class

    Public Class Paths

        Public Class Names
            Public Shared ServerLogsFolder = "Server Logs"
            Public Shared seDirectorLogPath = "seDirector_error.log"
            Public Shared HLDSUpdateToolName = "HldsUpdateTool.exe"
            Public Shared SteamCMDName = "steamcmd.exe"
        End Class

        Public Class Formats
            Public Shared ServerLogsPath = "{0}\{1}"
            Public Shared ServerLogsHostPath = "{0}\{1}\{2}"
            Public Shared ServerLogsHostServerPath = "{0}\{1}\{2}\{3}.log"

            Public Shared seDirectorLogPath = "{0}\{1}"
        End Class

        Public Class InternalNames
            Public Shared ServerLogsPath = "ServerLogsPath"
            Public Shared ServerLogsHostPath = "ServerLogsHostPath"
            Public Shared ServerLogsHostServerPath = "ServerLogsHostServerPath"

            Public Shared seDirectorLogPath = "seDirectorLogPath"

            Public Shared SteamCMD = "SteamCMD"
            Public Shared HLDSUpdateTool = "HLDSUpdateTool"
        End Class

    End Class

    Public Class Addons
        Public Class AddonNames
            Public Shared SourceMod = "SourceMod"
            Public Shared MetamodSource = "Metamod:Source"
        End Class

        Public Class Errors
            Public Shared MustInstallMetamodBeforeSourcemod = "Please install Metamod:Source before installing SourceMod."
            Public Shared ErrorInstaller = "Error 1009: An error occurred while attempting to {0} the addon."
            Public Shared ErrorInstallingUpdatingAddon = "Error while installing/updating addon."
            Public Shared ErrorChangingAddon = "There was an error while changing the addon. You may need to uninstall and reinstall the addon, or if having problems, restore from the backup file in addons\[Backups]."
            Public Shared ErrorChangingAddon2 = "Error while changing addon."
            Public Shared ErrorRemovingMetaMod = "Error while removing Metamod:Source:"
        End Class

        Public Class Notifications
            Public Shared BackupNotify = "Because this is {0} {1}, a backup of the {2} directory will be made."
            Public Shared BackupAsk = "{0} {1} {2} {3}?"
        End Class

        Public Class Other
            Public Shared ChangingAddon = "Changing Addon"
            Public Shared ChangingMetamodSource = "Changing Metamod:Source version"
            Public Shared ChangingSourceModVersion = "Changing SourceMod version"
            Public Shared CreatingBackup = "Creating Backup"
            Public Shared BackingUp = "Backing up {0}"
        End Class
    End Class

    Public Class MainWindow_ContextMenu
        Public Shared rcon = "rcon Server"
        Public Shared CreateBackup = "Create Backup"
        Public Shared Troubleshoot = "Troubleshoot"
        Public Shared Move = "Move"
        Public Shared GenerateReport = "Generate Report"
        Public Shared ConfigureAutomaticArchiving = "Configure Automatic Archiving"
    End Class

    Public Class MainWindow_Menu
        Public Shared ConnectivityAnalyzer = "Connectivity Analyzer"
        Public Shared SecurityAnalyzer = "Security Analyzer"
        Public Shared ServerMonitoring = "Server Monitoring"
        Public Shared ConnectMobileApp = "Connect Mobile App"
        Public Shared ServerExpenseSplitter = "Server Expense Splitter"
    End Class

    Public Class Donate
        Public Shared AutoClosingWindow = "Automatically closing this window in {0} seconds"
    End Class
End Class