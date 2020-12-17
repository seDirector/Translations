'Language file for seDirector
'------------------------------
'Language: English
'Last Updated: 2020-12-17
'Author: asheroto
'------------------------------

Public Class Lang
    Public Class UI
        Public Class MainWindow
            Friend Const Menu_Start = "Start"
            Friend Const Menu_Stop = "Stop"
            Friend Const Menu_Restart = "Restart"
            Friend Const Menu_Update = "Update"
            Friend Const Menu_Show_Hide = "Show/Hide"
            Friend Const Menu_Add_Server = "Add Server"
            Friend Const Menu_Delete_Server = "Delete Server"
            Friend Const Menu_Open_Game_Directory = "Open Game Directory"
            Friend Const Menu_Open_Maps_Directory = "Open Maps Directory"

            Friend Const Server_Name = "Server Name"
            Friend Const Status = "Status"
            Friend Const Uptime = "Uptime"
            Friend Const CPU = "CPU"
            Friend Const Memory = "Memory"
            Friend Const IP_Address = "IP Address"
            Friend Const Port = "Port"
            Friend Const Current_Map = "Current Map"
            Friend Const Players = "Players"
            Friend Const Game = "Game"

            Friend Const Information = "Information"
            Friend Const ServerName = "Server Name"
            Friend Const Created = "Created"

            Friend Const Events = "Events"
            Friend Const Logs = "Logs"
            Friend Const UptimeUptime = "Uptime"
            Friend Const Started = "Started"
            Friend Const Updated = "Updated"

            Friend Const Properties = "Properties"
            Friend Const Start = "Start"
            Friend Const StopStop = "Stop"
            Friend Const Restart = "Restart"
            Friend Const ShowHide = "Show/Hide"
            Friend Const Update = "Update"
            Friend Const AddServer = "Add Server"
            Friend Const DeleteServer = "Delete Server"
            Friend Const DuplicateServer = "Duplicate Server"
            Friend Const CreateBackup = "Create Backup"
            Friend Const RunBZ2 = "Run BZ2 Compression"
            Friend Const RunLocal = "Run Local/FTP/SFTP Sync"
            Friend Const Open = "Open"
            Friend Const Reorder = "Reorder"
            Friend Const OSL = "Open seDirector Log For Server"
            Friend Const OSLF = "Open Server Logs Folder"
            Friend Const CompressLogs = "Compress Logs"
            Friend Const GameDirectory = "Game Directory"
            Friend Const CMDDir = "CMD in Directory"
            Friend Const ConfigFiles = "Configuration Files"
            Friend Const Maps = "Maps"
            Friend Const Sound = "Sound"
            Friend Const SourceMod = "SourceMod"
            Friend Const Directory = "Directory"
            Friend Const Configs = "Configs"
            Friend Const Plugins = "Plugins"
            Friend Const PluginsSearch = "Plugins Search"
            Friend Const Forums = "Forums"
            Friend Const MoveToTop = "Move to Top"
            Friend Const MoveUp = "Move Up"
            Friend Const MoveDown = "Move Down"
            Friend Const MoveToBottom = "Move to Bottom"
            Friend const CreateServer = "Create Server"
            Friend Const ReloadSed = "Reload seDirector (keep servers running)"
            Friend const KillAll = "Kill All Process Instances"
            Friend Const OpenDefDir = "Open Default Directory"
            Friend Const OpenSL = "Open seDirector Log"
            Friend Const OpenSeDir = "Open seDirector Directory"
            Friend Const Options = "Options"
            Friend Const SupportRequest = "Support Request"
            Friend Const HelpTranslateSed = "Help Translate seDirector"
            Friend Const DiscordServer = "Discord Server"
            Friend Const DonateToSed = "Donate to seDirector"
            Friend Const RecFold = "Recommended Folder Structure"
            Friend Const CFGExamples = "CFG Examples"
            Friend Const ReleaseNotes = "Release Notes"
            Friend Const CFU = "Check for Updates"
            Friend Const About = "About"
        End Class

        Public Class ServerProperties
            Friend Const Properties_ServerName = "Server Name"
            Friend Const Properties_SRCDSLocation = "SRCDS Location"
            Friend Const Properties_Game = "Game"
            Friend Const Properties_IPAddress = "IP Address (optional)"
            Friend Const Properties_PortNumber = "Port Number"
            Friend Const Properties_ExecuteCFG = "Execute CFG"
            Friend Const Properties_Map = "Map"
            Friend Const Properties_NumberOfPlayers = "Number of Players"
            Friend Const Properties_Secure = "Secure"
            Friend Const Properties_AdditionalParameters = "Additional Parameters"
            Friend Const Properties_ProcessorAffinity = "Processor Affinity"
            Friend Const Properties_ProcessPriority = "Process Priority"
            Friend Const Properties_CommandToRun = "Command to Run"
            Friend Const Properties_ = "Properties"
            Friend Const Properties_Browse = "Browse"
            Friend Const Properties_Create = "Create"
            Friend Const Properties_CustomGameMod = "Custom Game / Mod"
            Friend Const Properties_UsePrivateIPUnlessOnDMZ = "Use private IP unless on DMZ"
            Friend Const Properties_NextAvailable = "Next Available"
            Friend Const Properties_CreateServerCFG = "Create server.cfg"
            Friend Const Properties_LocalMap = "Local Map"
            Friend Const Properties_WorkshopCustomMap = "Workshop / Custom Map"
            Friend Const Properties_UseAdditionalParametersToAdjust = "(use additional parameters to adjust)"
            Friend Const Properties_NormalRecommendedRealtimeNotRecommended = "Normal is recommended; realtime is not recommended"

            Friend Const Properties_ServerPropertiesCannotBeChangedWhileRunning = "Server Properties cannot be changed while running"
            Friend Const Properties_PleaseFillRequiredFields = "Please fill required fields"
            Friend Const Properties_SaveSettings = "Save Settings"

            Friend Const StartOptions = "Start Options"
            Friend Const StartThisServerWhenSedirectorStarts = "Start this server when seDirector starts"
            Friend Const HideServerWindow = "Hide server window"
            Friend Const HideUpdateWindow = "Hide update window"
            Friend Const UpdateOptions = "Update Options"
            Friend Const ValidateUpdate = "Validate Update Every Time (adds the -validate parameter to SteamCMD)"
            Friend Const ValidateUpdateUse = "Use this if your servers aren't updating or working properly."
            Friend Const UpdateAutoCurMapCurPlayers = "Update Automatically, Current Map, Current Players"
            Friend Const SaveAndReopen = "Save and reopen to change these settings"
            Friend Const PluginDescription = "seDirector can update your server automatically when Steam's content servers change. For these features to work, you must have SourceMod installed prior to installing this plugin (except if game server is Garry's Mod)."
            Friend Const PluginDescription2 = "The seDirector plugin also updates the 'Current Map' and 'Players' columns on the server list."
            Friend Const UpdateAuto = "Update Automatically"
            Friend Const SpecialCSGO = "Special Instructions for CSGO Servers"
            Friend Const PluginStatus = "Plugin Status"
            Friend Const Installed = "Installed"
            Friend Const NotInstalled = "Not Installed"
            Friend Const Install = "Install"
            Friend Const Uninstall = "Uninstall"
            Friend Const Directory = "Directory"
            Friend Const CrashRecovery = "Crash Recovery"
            Friend Const RecoverFromServerCrash = "Recover from server crash"
            Friend Const HowCrashRecoveryWorks = "How crash recovery works"
            Friend Const CrashRecovery1 = "seDirector keeps count of how many times a server has crashed.  If a server has crashed 2 times in 10 minutes, seDirector will automatically try to update the server.  If the server crashes again within 10 minutes after the update, seDirector will stop the server.  If a server has gone more than 10 minutes without crashing, the crash counter will reset."
            Friend Const CrashRecovery2 = "1 crash in 10 minutes = okay"
            Friend Const CrashRecovery3 = "2 crashes in 10 minutes = attempt to update"
            Friend Const CrashRecovery4 = "1 crash in 10 minutes after updating = server will stop (notification sent if enabled)"
            Friend Const CrashRecovery5 = "Every 10 minutes without a crash = count resets"

            Friend Const AddonsFolder = "Addons Folder"
            Friend Const NotSet = "not set"
            Friend Const MoreInfo = "More Info"
            Friend Const Name = "Name"
            Friend Const YourVersion = "Your Version"
            Friend Const LatestVersion = "Latest Version"
            Friend Const Path = "Path"
            Friend Const SaveAndReopenToChange = "Save and reopen to change these settings"
            Friend Const AddonsNotSupported = "Addons not supported in this game server"
            Friend Const Actions = "Actions"
            Friend Const AddOn = "Add-on"
            Friend Const VersionToInstall = "Version to Install"
            Friend Const InstallChange = "Install/Change"
            Friend Const Publisher = "Publisher"
            Friend Const Description = "Description"
            Friend Const Website = "Website"
            Friend Const Documentation = "Documentation"
            Friend Const Forum = "Forum"
            Friend Const PluginsAddons = "Plugins/Addons"
            Friend Const AndAnd = "and"
            Friend Const NoAvailableAddonsToInstall = "No available addons to install."

            Friend Const WhenWhen = "When"
            Friend Const Action = "Action"
            Friend Const Daily = "Daily"
            Friend Const Weekly = "Weekly"
            Friend Const Monthly = "Monthly"
            Friend Const OnAnEvent = "On an Event"
            Friend Const Hour = "Hour"
            Friend Const Minute = "Minute"
            Friend Const Crashes = "Crashes"
            Friend Const UpdateComplete = "Update Complete"
            Friend Const SaveTask = "Save Task"
            Friend Const Cancel = "Cancel"
            Friend Const RestartServer = "Restart Server"
            Friend Const RestartServer2 = "Restart Server w/In-Game Notification (Plugin Required)"
            Friend Const UpdateServer = "Update Server"
            Friend Const UpdateServer2 = "Update Server w/In-Game Notification (Plugin Required)"

            Friend Const TextOrCFGFile = "Text or CFG File"
            Friend Const BZ2Compression = "BZ2 Compression"
            Friend Const BZ2CompressionExplained = "BZ2 compression allows content to be downloaded to a player's computer much faster than downloading the traditional BSP files.  It is similar to a ZIP file except it ends in BZ2.  The files are created in the same directory as the content."
            Friend Const AutoCompressUncompressed = "Automatically compress uncompressed content on server start"
            Friend Const WhatToCompress = "What to Compress"
            Friend Const HTTPFastDownload = "HTTP Fast Download"
            Friend Const HTTPFastDownloadExplained = "You may enable Directory Synchronization and/or FTP/SFTP Synchronization so that your content is automatically updated on your web server every time this server is started. Sync works by mirroring the maps, sound, materials, model, and resource directories. If target directories already exist they will be updated to match this server's content. Only BZ2 files will be synced."
            Friend Const HTTPFastDownloadExplained2 = "Create a new, empty directory on your web server and specify its location below."
            Friend Const DirSyncHTTP = "Directory Synchronization for HTTP Fast Download"
            Friend Const DirSyncHTTP2 = "Enable Directory Synchronization"
            Friend Const DirSyncHTTP3 = "Generally used if your web server is on the same computer as your game server(s)"
            Friend Const TargetDirectory = "Target Directory"
            Friend Const FTPSFTPSync = "FTP/SFTP Synchronization for HTTP Fast Download"
            Friend Const EnableFTPSFTP = "Enable FTP/SFTP Synchronization"
            Friend Const Server = "Server"
            Friend Const Username = "Username"
            Friend Const Password = "Password"
            Friend Const ConnectionType = "Connection Type"
            Friend Const Port = "Port"
            Friend Const RemoteDir = "Remote Directory"
            Friend Const SFTPRecommended = "SFTP is recommended because it encrypts your credentials"
            Friend Const TestCon = "Test Connection"

            Friend Const ExampleNotification = "Example Notification"
            Friend Const ExampleNotification_Subject = "Subject"
            Friend Const ExampleNotification_SubjectData = "seDirector Alert: Server <ServerName>"
            Friend Const ExampleNotification_Body = "Body"
            Friend Const ExampleNotification_BodyData = "Server <ServerName> has crashed and seDirector is unable to recover it automatically."
            Friend Const EmailTextSMS = "E-mail/Text/SMS Notifications"
            Friend Const EmailTextSMS2 = "seDirector will automatically notify you via e-mail if your server crashes and is unable to be recovered automatically OR if a server fails to start successfully.  The 'Recover from server crash' checkbox on the Automation tab MUST be checked in order for e-mail notifications to work."
            Friend Const EnableEmailNotifications = "Enable E-mail Notifications"
            Friend Const WantToReceive = "Want to receive a text/SMS?"
            Friend Const CopyFromOtherServer = "Copy From Other Server"
            Friend Const SendTestEmail = "Send Test E-mail"
            Friend Const DiscordNotifications = "Discord Notifications"
            Friend Const DiscordNotifications2 = "seDirector will automatically notify you via Discord if your server crashes and is unable to be recovered automatically OR if a server fails to start successfully.  The 'Recover from server crash' checkbox on the Automation tab MUST be checked in order for Discord notifications to work."
            Friend Const EnableDiscordNotifications = "Enable Discord Notifications"
            Friend Const DiscordWebhook = "Discord Webhook"
            Friend Const HowDoI = "How do I get a webhook?"
            Friend Const SendTestNotif = "Send Test Notification"
        End Class

        Public Class Options
            Friend Const Application = "Application"
            Friend Const Language = "Language"
            Friend Const HelpTranslate = "Help Translate seDirector!"
            Friend Const SOWS = "Start on Windows startup"
            Friend Const MTSTOC = "Minimize to system tray on close"
            Friend Const DNCCP = "Do not check for current players and current map"
            Friend Const DNAU = "Do not automatically update seDirector"
            Friend Const CDS = "Create desktop shortcut for seDirector"
            Friend Const RecommendedFolder = "Click Here for the Recommended Folder Structure to Use With seDirector"
            Friend Const DDTB = "Default Directory to Browse"
            Friend Const Browse = "Browse"
            Friend Const MoreInfo = "More Info"
            Friend Const SUT = "Server Update Tool"
            Friend Const SCL = "SteamCMD location"
            Friend Const Clear = "Clear"
            Friend Const Download = "Download"
            Friend Const SteamLogin = "Steam Login"
            Friend Const SteamLoginDesc = "Optional.  Only required for some games or if you are doing something advanced."
            Friend Const Username = "Username"
            Friend Const Password = "Password"
        End Class

        Public Class CreateServer
            Friend Const Game = "Game"
            Friend Const ITD = "Instal to Directory"
            Friend Const Browse = "Browse"
            Friend Const CreateServer = "Create Server"
        End Class
    End Class

    Public Class Controller
        Friend Const PreviouslyUsedSedirector = "Have you previously used seDirector on this computer?"
        Friend Const PleaseSelectPreviousSedirector = "Please select the previous version of seDirector so your data can be upgraded."
        Friend Const SelectPreviousVersionOfSedirector = "Select previous version of seDirector"
        Friend Const XMLFileNotExist = "{0} does not exist in the location you specified. Please make sure {0} is in the same directory as seDirector and try again."
        Friend Const DataUpgradeSuccess = "Data upgraded successfully. Please relaunch seDirector."
        Friend Const ErrorMovingFilesManuallyMove = "There was an error moving one or more of the files. Please manually move Servers.xml and Settings.xml to the following directory, then restart seDirector."
    End Class

    Public Class CreateServer
        Friend Const SelectEmptyDirectoryForServer = "Select an EMPTY directory to install the server.  Make a new directory if needed."
        Friend Const CannotUseRootDirectoryDrive = "You cannot use the root directory of a drive."
        Friend Const DirectoryNotEmptyOverwrite = "Directory is not empty. Files may be overwritten! Proceed?"
        Friend Const UserPassReqToUpdate = "A username and password for Steam is required to update this game. Please set it in Tools->Options and return to this window."
    End Class

    Public Class FTP
        Friend Const CouldNotConnectServer = "Could not connect to server. Check the server, port, username, password, and connection type."
        Friend Const CouldNotRetrieveDirectoryContents = "Could not retrieve directory contents."
        Friend Const CouldNotWriteTestFile = "Could not write test file. Please check for write access to this directory."
        Friend Const CouldNotDeleteTestFile = "Could not delete test file. Please check for delete access to this directory."
        Friend Const FTPSFTPSync = "FTP/SFTP Sync"
        Friend Const FTPSFTPSyncInProgress = "FTP/SFTP sync in progress... This may take several minutes..."
        Friend Const InvalidUserPass = "Invalid username or password."
        Friend Const ErrorInitializingSFTP = "Error initializing SFTP subsystem"
        Friend Const CouldNotReadDirectoryContents = "Could not read directory contents. Check for read access to this directory."
        Friend Const ErrorWhileReadingDirectoryContents = "Error while reading directory contents."
        Friend Const NoItemsFoundInDirectory = "No items found in this directory."
        Friend Const CouldNotOpenTestFileForWriting = "Could not open test file for writing. Please check for write access to this folder."
    End Class

    Public Class GameCommon
        Friend Const UpdatedPlugin = "Updated plugin"
    End Class

    Public Class Networking
        Friend Const Downloading = "Downloading"
        Friend Const DownloadingX = "Downloading {0}"
        Friend Const ErrorWhileDownloadingFile = "There was an error while trying to download a file."
        Friend Const Extracting = "Extracting"
        Friend Const ExtractingX = "Extracting {0}"
        Friend Const SteamCMDNeedsUpdate = "SteamCMD has been downloaded and needs to update for the first time. The next window will close automatically when finished, please do not close out of it manually."
        Friend Const ErrorWhileTryingToExtract = "There was an error while trying to extract."
    End Class

    Public Class Options
        Friend Const DesktopShortcutSuccess = "Desktop shortcut success"
        Friend Const DesktopShortcutError = "Desktop shortcut error"
        Friend Const DefaultDirectory = "Default directory"
        Friend Const SelectEmptyDirForSteamCMD = "Select an empty directory to install SteamCMD. Make a new directory if needed."
        Friend Const DirNotEmptyOverwrite = "Directory is not empty. Files may be overwritten! Proceed?"
        Friend Const ErrorTryingDownload = "Error while trying to download {0}. Internet connection issue?"
        Friend Const SelectDirMostCommonUsed = "Select the directory you most commonly use in seDirector."
        Friend Const UnsureCreateDir = "Unsure? Create a directory under C:\ called Steam and select it."
        Friend Const DefaultDirToBrowse = "The 'Default Directory to Browse' setting tells seDirector to automatically open to the specified directory automatically when browsing for a file or folder. That way you don't have to go through Computer->C Drive->Steam->etc every time, it will automatically open to the directory you set it to."
    End Class

    Public Class Progress
        Friend Const CancelCurrentDownload = "Cancel the current download?"
        Friend Const CancelExtractOp = "Cancel the extract operation?"
        Friend Const CancelCurrentBackup = "Cancel the current backup operation?"
        Friend Const CancelBZ2Compression = "Cancel BZ2 compression?  All files will be recompressed the next time you start the server."
        Friend Const CancelFTPSync = "Cancel FTP synchronization?  Some files may be partially uploaded.  Resyncing will resolve partial uploads."
        Friend Const CancelLocalSync = "Cancel local directory synchronization?  Some files may be partially copied.  Resyncing will resolve partial files."
        Friend Const CancelDirectoryDuplication = "Cancel server directory duplication?"
    End Class

    Public Class ServerConfig
        Friend Const CouldNotDetectSteamInf = "Couldn't detect steam.inf in game directory. Please open Properties and select srcds.exe again. If the problem persists, turn on the -validate update option in properties and update, then turn it back off."
        Friend Const CouldNotLocateSteamInf = "Could not locate steam.inf in game directory."
        Friend Const ThisServerFailedToStartSuccessfully = "This server failed to start successfully."
        Friend Const ErrorLoadingServersXML = "There was an error loading the Servers.xml data file. This could be caused by a bug in seDirector. If Servers.xml is empty, delete the file and either restore it from a backup or add your servers back to seDirector manually. Please email support@sedirector.net and let us know what you were doing in seDirector right before this happened. Attach Servers.xml to your email if it is NOT empty."
    End Class

    Public Class SupportRequest
        Friend Const PleaseEnterEmail = "Please enter a valid e-mail address."
        Friend Const ErrorSendingRequest = "There was an error sending your request. Check your Internet connection or e-mail support@sedirector.net if the problem continues."
        Friend Const MessageSent = "Your message has been sent. Please allow 1 to 2 business days for a reply. Thank you."
        Friend Const ErrorSendingInformation = "There was an error sending the information. Check your Internet connection and contact support@sedirector.net if the problem persists."
    End Class

    Public Class Status
        'Text for statuses
        Friend Const Running = "Running"
        Friend Const Offline = "Offline"
        Friend Const Starting = "Starting"
        Friend Const Stopping = "Stopping"
        Friend Const ErrorStarting = "Error Starting"
        Friend Const ErrorStopping = "Error Stopping"
        Friend Const UpdateStarting = "Update Starting"
        Friend Const Updating = "Updating"
        Friend Const UpdateError = "Update Error"
        Friend Const PendingRestart = "Pending Restart"
        Friend Const PendingUpdate = "Pending Update"
    End Class

    Public Class MainWindow
        'Text for the main window
        Friend Const AllHosts = "All Hosts"

        Friend Const Uptime = "Uptime"
        Friend Const Started = "Started"
        Friend Const LastUpdated = "Last Updated"

        Friend Const TheMaxNumberOfServers = "The maximum number of servers is {0}."

        Friend Const StartingMap = "Starting Map"
        Friend Const CurrentMap = "Current Map"

        Friend Const ServerCrashedEvenAfterUpdating = "Server crashed even after updating"
        Friend Const SentServerCrashEmail = "Sent server crash e-mail notification"
        Friend Const SentServerCrashDiscord = "Sent server crash Discord notification"

        Friend Const ZipFiles = "Zip Files"
        Friend Const Backup = "Backup"

        Friend Const ErrorCheckingNewerVersionSedirector = "Error 1007: Error checking for newer version of seDirector. Check your Internet connection and try again or contact seDirector support if the problem persists."

        Friend Const TaskRequestedServerRestart = "Task requested server restart."
        Friend Const TaskRequestedServerRestartInGame = "Task requested server restart w/in-game notification"
        Friend Const RestartServer = "Restart Server"
        Friend Const RestartServerInGame = "Restart Server w/In-Game Notification (Plugin Required)"

        Friend Const Daily = "Daily"
        Friend Const Weekly = "Weekly"
        Friend Const Monthly = "Monthly"

        Friend Const UpdateServer = "Update Server"
        Friend Const UpdateServerInGame = "Update Server w/In-Game Notification (Plugin Required)"
        Friend Const TaskRequestedUpdateInGame = "Task requested server update w/in-game notification"
        Friend Const Detected = "Detected"
        Friend Const ServerBZ2CompCanceled = "Server BZ2 compression cancelled"
        Friend Const ServerLocalDirSyncCanceled = "Server local directory sync cancelled"
        Friend Const ServerFTPCanceled = "Server FTP/SFTP sync cancelled"
        Friend Const SedirectorAlert = "seDirector Alert"
        Friend Const Server = "Server"
        Friend Const ServerCrashedUnableToRecoverAuto = "Server {0} has crashed and seDirector is unable to recover it automatically."
        Friend Const ErrorSendingTestEmailContact = "Error sending test e-mail. Contact seDirector support."
        Friend Const DiscordNotificationSent = "Discord notification sent."
        Friend Const ErrorSendingDiscordNotification = "Error sending Discord notification. Confirm that your webhook URL Is correct And try again. If the problem persists, contact seDirector support."
        Friend Const LocalDirSync = "Local Directory Sync"
        Friend Const LocalDirSyncInProgress = "Local directory sync in progress... This may take several minutes..."
        Friend Const DoDuplicateGameDir = "Do you want to duplicate the game server's directory contents?"
        Friend Const SelectEmptyDir = "Select an EMPTY directory to copy the server's folder contents. Make a new directory if needed."
        Friend Const CannotUseRootDir = "You cannot use the root directory of a drive."
        Friend Const DirNotEmpty = "Directory is not empty. Please choose an empty directory to place the server's folder contents."
        Friend Const CopyingGameSerDirCont = "Copying game server directory..."
        Friend Const CopyingGameSerDir = "Copying game server directory..."
        Friend Const Calculating = "Calculating"
        Friend Const ErrorDuringServerDup = "Error during server duplication"
        Friend Const RecommendedFolderStruc = "Recommended Folder Structure"
        Friend Const DonateToSedirector = "Donate to seDirector"
    End Class

    Public Class URLs
        Friend Const UpdateUrl = "https://api.sedirector.net/update"
        Friend Const ReleaseNotesUrl = "https://api.sedirector.net/release-notes/"

        Friend Const AutomaticUpdateMoreInfoUrl = "https://sedirector.net"
        Friend Const seDirectorURL = "https://sedirector.net"

        Friend Const SteamTools = "http://forums.alliedmods.net/showthread.php?t=129763"
        Friend Const SourceMod = "http://www.sourcemod.net"

        Friend Const seDirector_Support = "https://sedirector.net"

        Friend Const SteamCMD_URL = "http://media.steampowered.com/installer/steamcmd.zip"

        Friend Const AddonListUrl = "https://api.sedirector.net/addons/"

        Friend Const HTTPFastDownload_URL = "https://support.steampowered.com/kb_article.php?ref=9717-HMAP-7066"
    End Class

    Public Class Notifications
        'Text for notifications
        Friend Const DebugModeEnabled = "Debug mode Is enabled!"
        Friend Const RunningNotAttached = "{0} Is running And Is Not attached to seDirector. Click OK to terminate the process Or cancel to exit seDirector."
        Friend Const ForceUpdateSedirector = "Force update seDirector?"
        Friend Const DesktopShortcutCreated = "Desktop shortcut created."
        Friend Const StartMenuShortcutCreated = "Start Menu shortcut created."
        Friend Const ShortcutError = "There was an error creating the shortcut. Please make sure you have access to the desktop. Check the log file for more information."
        Friend Const SteamUsernamePasswordChanged = "The Steam username Or password has changed. Please enter the Steam Guard code (sent to your e-mail) on the following window if asked. Do Not close out of the next window, let it close automatically. If you mess up, just press backspace to correct." + vbCrLf + vbCrLf + "If you need the code to be sent again, press Ctrl-C one time And let it close automatically, set your username to something else, Save, then change it back to the correct value, Save."
        Friend Const CannotUseRootDirectoryOfDrive = "You cannot use the root directory of a drive."
        Friend Const PleaseSelectSrcdsInGameDirectory = "Please select srcds.exe in the game's directory."
        Friend Const ErrorStartingServer = "Error starting server"
        Friend Const MaxStartAttemptsReached = "Cannot start after {0} attempts. User required."
        Friend Const MaxCrashesOccurred = "Server crashed {0} times in a row. User required."
        Friend Const NoCrashesInTenMinutes = "No crashes in 10 minutes"
        Friend Const SecondCrashInTenMinutesUpdating = "2nd crash in 10 minutes - attempting to update server"
        Friend Const ErrorServerRecommendation = "Run an update on the server to see if that fixes the problem.  If that does not fix it there may be a problem with an addon or plugin.  Check the server's error logs for more information."
        Friend Const CrashedByClosing = "Crashed by closing"
        Friend Const DetectedNotResponding = "Detected not responding, retrying in 10 seconds"
        Friend Const CrashByNotResponding = "Crashed by not responding"
        Friend Const ManualInterventionRequired = "Manual intervention required"
        Friend Const DetectedUpdate = "Detected update request"
        Friend Const DetectedRestartRequest = "Detected restart request"
        Friend Const ServerStoppedForUpdating = "Server stopped for updating"
        Friend Const ServerStoppedForPendingRestart = "Server stopped for pending restart"
        Friend Const UpdateComplete = "Update complete"
        Friend Const AreYouSureTerminate = "Are you sure you want to terminate all instances of {0}.exe?"
        Friend Const AllInstancesOf = "All instances of {0}.exe have been terminated if they existed."
        Friend Const QuitConfirm = "There are servers running or updating.  If you exit, all servers will be stopped. Are you sure you want to exit?"
        Friend Const ErrorStartingServerRecommendation = "Error 1009: There was an error starting {0}.  Make sure the port you are using is an available port (one port per server per host) and that the IP address is valid.  If you still experience problems, try updating the server or running the server manually to correct the problem.  Sometimes a lower version of SourceMod or Metamod is required in order to run the game."
        Friend Const ErrorStartingUpdateRecommendation = "Error 1010: There was an error starting an update on server {0}. We've found the most common problem is that the " + Chr(34) + "Automatically detect settings" + Chr(34) + " checkbox is unchecked in Internet Options->Connections->LAN Settings. If it is checked, redownload {1}. Launch {1} through a command prompt for more information. Sometimes a lower version of SourceMod or Metamod is required in order to run the game." + vbCrLf + vbCrLf + "Here's the {1} command line w/arguments:" + vbCrLf + vbCrLf + "{1}.exe {2}"
        Friend Const QuitServerForUpdateConfirmation = "Server {0} is currently running." + vbCrLf + vbCrLf + "Do you want to stop the server to proceed with updating?"
        Friend Const DeleteServerConfirmation = "Are you sure you want to delete server {0}?"
        Friend Const EmailInfo = "If e-mail alerts are enabled on a server, you'll receive alerts from alerts@sedirector.com automatically. No need to bother with SMTP settings - e-mail notifications are included as part of your seDirector account."
        Friend Const BetaNotice = "You are running a {0} version of seDirector that will expire in {1} days." & vbCrLf & vbCrLf & "Would you like to sign up for the mailing list to be notified when stable releases are available?"
        Friend Const BetaExpired = "This version of seDirector has expired. Press OK to go to AsherSoftware.com for an updated version."
        Friend Const BetaNotificationText = "{0} version - NOT a stable release - some features disabled"
        Friend Const NoAvailableUpdates = "No available updates at this time."
        Friend Const DotNetFrameworkNeeded = "You must have .NET Framework 4.5 or higher to run seDirector." & vbCrLf & vbCrLf & "Press OK to open the .NET Framework download page."
        Friend Const NewerVersionAvailable = "A newer version of seDirector is available." & vbCrLf & vbCrLf & "Current Version: {0}" & vbCrLf & "New Version: {1}" & vbCrLf & vbCrLf & "Would you like to update seDirector?  Your servers will continue to run during the seDirector update process."
        Friend Const AutomaticUpdateInfo = "seDirector supports the ability to update a server automatically when Steam's servers have an update available. For this to work you must have SourceMod installed with the SteamTools extension and the seDirector plugin." & vbCrLf & vbCrLf & "Press OK to open the seDirector plugin page."
        Friend Const FileDoesNotExist = "{0} does not exist in the specified location."
        Friend Const GameServerDirectoryMissing = "The game directory for server {0} is missing.  Please select srcds.exe again."
        Friend Const CreateServerConfirm = "Create {0} in {1}?"
        Friend Const UpdateToolMissing = "{0} is missing.  Please go to Tools->Options to set the location of {0}."
        Friend Const UpdateToolNotSelected = "An update tool has not been selected for {0}.  Please go to the Automation tab in the server's properties to select an update tool."
        Friend Const ServerBeingCreated = "The server is now being created.  Please wait until the updater/installer has finished, then select srcds.exe in the server properties window."
        Friend Const DownloadingUpdateTool = "Click OK to download {0}.  After the download is complete, extract the exe from the zip file and place an the appropriate directory, then come back to this screen."
        Friend Const NoUpdateToolSet = "An update tool has not been set on {0} of your servers.  Please set the update tool in the Automation tab of the server's properties."
        Friend Const ShuttingDownProper = "Shutting Down"
        Friend Const ShuttingDown = "Shutting down"
        Friend Const AddonUpdateFailure = "Error 1011: Error when trying to download the addon lists. Check your Internet connection or contact seDirector support if this issue continue."
        Friend Const AddonBackupFailure = "Error 2017: Error when backing up the existing addon. Please try again."
    End Class

    Public Class Backups
        Friend Const CreateBackupAsk = "Create backup for server {0}?"
        Friend Const CreatingBackupCaption = "Creating Backup"
        Friend Const BackingUpServer = "Backing up {0}"
    End Class

    Public Class Compressing
        Friend Const CompressingToBZ2 = "Compressing to BZ2"
        Friend Const CompressingXToBZ2 = "Compressing {0} to BZ2..."
        Friend Const RecompressingDueToCancel = "(recompressing all due to previous cancellation)"
    End Class

    Public Class LogsLogs
        Friend Const CompressLogsAsk = "Compress the logs for server {0}?"
        Friend Const LogsDirectoryDNE = "Logs directory does not exist!"
        Friend Const CompressingLogsCaption = "Compressing Logs"
        Friend Const CompressingLogsDescription = "Compressing logs {0}"
    End Class

    Public Class Errors
        Friend Const ErrorCreatingServer = "Error 1012: There's a problem with {0}. We've found the most common problem is that the " + Chr(34) + "Automatically detect settings" + Chr(34) + " checkbox is unchecked in Internet Options->Connections->LAN Settings. If it is checked, redownload {0}. Launch {0} through a command prompt for more information."
    End Class

    Public Class Crashes
        Friend Const NegativeMemory = "Crashed by negative memory (not responding?)"
    End Class

    Public Class ServerProperties
        Friend Const Addons = "Addons"
        Friend Const CopyOf = "Copy of"

        Friend Const MetamodSource = "Metamod:Source is a C++ plugin environment for Half-Life 2. It acts as a 'metamod' which sits in between the Game and the Engine, and allows plugins to intercept calls that flow between. It provides a mechanism called SourceHook, a very powerful library for intercepting, overridding, and superseding virtual function calls."
        Friend Const SourceMod = "SourceMod is server modification for any game that runs on the Half-Life 2 engine. It is a powerful, highly optimized platform for scripting plugins and handling server administration. The default package comes with a base set of plugins, but there are over 2,500 plugins in the community."
        Friend Const VersionListEmpty = "The {0} version list is empty. To fix this, simply restart seDirector, wait 5 seconds, then open the server's properties again. Would you like to restart seDirector? Running servers will remain running.?"
        Friend Const ErrorInstallingAddon = "Error installing addon. Check your Internet connection and try again."

        Friend Const TaskConfirm = "Are you sure you want to remove task {0}?"

        Friend Const RemovingMetamodAffectSourcemod = "Removing Metamod will stop SourceMod from working. You must remove SourceMod first."
        Friend Const RemovingUlibAffectUlx = "Removing ulib will stop ulx from working. You must remove ulx first."
        Friend Const RemoveXFromServer = "Remove {0} from this server?"
        Friend Const WarningAllDataDeleted = "WARNING: All add-on data will be deleted."
        Friend Const AddonCouldNotBeDetected = "Addon could not be detected. Make sure you have permission to write to {0} and rerun the Install/Change process."
        Friend Const DoesNotExistClick = "Does not exist. Click here to create it."

        Friend Const SaveChangesFile = "Save changes to file?"
        Friend Const ProblemFileNotExist = "Problem opening file. File does not exist."
        Friend Const CouldNotSaveFile = "Could not save file"

        Friend Const YouShouldCreateDirUnique = "You should create a directory on your web server unique to this game server."
        Friend Const Example = "Example"
        Friend Const URL = "URL"
        Friend Const RemoteDir = "Remote Directory"

        Friend Const Connecting = "Connecting"

        Friend Const AllTestsPassedFTP = "All tests passed. FTP/SFTP synchronization should work."
        Friend Const OneMoreTestFailedFTP = "One or more tests failed. FTP/SFTP synchronization won't work until the previous errors are resolved."
        Friend Const ErrorTestingFTP = "There was an error testing the FTP/SFTP connection. Please make sure all fields are filled out properly."
        Friend Const TestCon = "Test Connection"
        Friend Const ForExample = "For example:"
        Friend Const SpecialInstructionsCSGO = "Special Instructions for CSGO"
        Friend Const PluginRequired = "Plugin Required"

        'The use of the below three variables is as specified in the last variable
        Friend Const SpecifyExactPath = "Specify the exact path to the game directory directory that contains the maps, sound, etc, subdirectory."
        Friend Const WouldBeAccessibleAt = "would be accessible via HTTP at"
        Friend Const UseTestConnection = "Use the Test Connection button to ensure you can connect and that you have specified the correct directory."
        Friend Const SWU_EXAMPLE = Lang.ServerProperties.SpecifyExactPath & vbNewLine & vbNewLine & Lang.ServerProperties.ForExample & vbNewLine & "/var/www/yourdomain.com/assets/tf2" & vbNewLine & Lang.ServerProperties.WouldBeAccessibleAt & vbNewLine & "http://yourdomain.com/assets/tf2/" & vbNewLine & vbNewLine & Lang.ServerProperties.UseTestConnection

        Friend Const CSGO_Plugin_Info = "<p>With CSGO, the server hibernates before the seDirector plugin has a chance to turn that off. You must set <strong>sv_hibernate_when_empty</strong> to <strong>0</strong> in your cfg file that starts the server, otherwise the seDirector plugin will NOT work.</p> <p> <strong>If you don't set this cvar to 0:</strong><br> (1) Updates will not occur until a player joins<br> (2) After players are notified in-game of a server update, if all leave before the countdown reaches 0, your server will never update<br> (3) Because of 1+2, this causes an endless loop of in-game updates and thus an outdated server </p> <p>You <i>cannot</i> simply turn off hibernation later, it must be done in the cfg file that launches when your server runs.</p> <p><strong>Add this line to your cfg file and make sure it's not anywhere else:</strong><br> sv_hibernate_when_empty 0 </p>"
        Friend Const AddonInfo = "Addon Info"
        Friend Const AddonInfoInfo = "<style> body { margin: 0; padding: 0; font-family: Tahoma, Geneva, sans-serif; font-size: 13px; } </style> <h3>Most Games: Metamod:Source | SourceMod</h3> <p> seDirector supports installing, upgrading, downgrading, reinstalling, and removing addons. seDirector is smart when changing the addons; it will only install the files necessary to change the versions - it will not remove your cfg files or extensions.<br><br> If an addon is upgraded, downgraded, or reinstalled, a backup will be made prior to taking any action. Look under the addons\[Backups] directory for the backups created by seDirector.<br><br> <b>MAKE SURE to test your server</b> after making addon changes. Type 'meta version' in console to make sure <b>Metamod:Source</b> is working. Type 'sm version' in console to make sure <b>SourceMod</b> is working. If you receive an error message after an update has been installed/changed, make sure you're using the latest version. Older versions may not work properly and cause your server to crash or plugins to malfunction.<br><br> <b>SourceMod</b> depends on <b>Metamod:Source</b> to work. Make sure to use a version of <b>SourceMod</b> compatible with your version of <b>Metamod:Source</b>. After installing <b>Metamod:Source</b>, the metamod.vdf file is automatically generated specific to your game server. </p> <h3>Garry's Mod: ulib | ulx | wiremod</h3> <p> seDirector supports installing and removing ulib, ulx, and wiremod. Upgrading/downgrading is not supported. Most of the update-related features are handled by the scripts themselves, so there probably won't be much of a need to upgrade or downgrade anyway.<br><br> <b>MAKE SURE to test your server</b> after making addon changes.<br><br> If you already have ulib, ulx, or wiremod installed and you want seDirector to detect it, rename game\addons\ulib-oldname to game\addons\ulib, game\addons\ulx-oldname to game\addons\ulx, game\addons\wiremod-oldname to game\addons\wiremod. </p>"

        Friend Const YouHaveSelectedActionSedirectorPlugin = "You've selected an action that can only be used if the seDirector plugin is installed. Please make sure to install this before you save the task, otherwise you will run into issues."

        Friend Const SelectDestinationDirSync = "Select the destination directory for directory synchronization"
        Friend Const UseFormatBelowNotifEmail = "Use the format below as your notification e-mail address."
        Friend Const PleaseEnterServerNameProp = "Please enter a server name in the Properties tab before testing notifications."
        Friend Const PleaseEnterEmailAddressTesting = "Please enter an e-mail address before testing notifications."
        Friend Const PleaseCheckDiscordWebhook = "Please check the Discord webhook URL and try again."
        Friend Const DiscordWebhookMoreInfo = "A Discord webhook is required in order for this to work. If you don't already have a Discord server for these notifications, create a new Discord server. Once created, go into the Discord server (or channel) settings, click on Integrations, and click 'New Webhook'. Copy the webhook URL and paste it into seDirector."

        Friend Const ServerCfgAlreadyExist = "Server.cfg already exists in this game's cfg directory, do you want to save it as server.cfg.example instead?"

        Friend Const WindowCaptionNewServer = "New Server"
        Friend Const WindowCaptionServer = "{0} - Properties"
        Friend Const PluginSuccessfullyInstalled = "Plugin successfully installed."
        Friend Const ErrorInstallingPlugin = "Error 1007: Error installing plugin. Please make sure you have access to the plugins directory."
        Friend Const PluginSuccessfullyRemoved = "Plugin successfully removed."
        Friend Const ErrorRemovingPlugin = "Error 1008: Error removing plugin. Please make sure no other programs are using this plugin. Close out of any Windows Explorer instances you may have open. Restart the computer if necessary."

        Friend Const PortNotAllowed = "{0} port not allowed"
        Friend Const PortAssignedToAnotherServer = "Port assigned to another server"

        Friend Const AnotherPropertiesWindowOpen = "Another properties window is already open.  Please close the other window before opening a new one."
        Friend Const AllProcessors = "All Processors"

        Friend Const Installed = "Installed"
        Friend Const NotInstalled = "Not Installed"

        Friend Const NotTheUpdateTool = "You can choose {0} as the update tool, however, {1} is the standard update tool for {2}.  Updating with {0} is not officially supported and may not work properly." + vbCrLf + vbCrLf + "Do you still want to save this configuration?"
        Friend Const AnUpdateToolHasNotBeenSelected = "An update tool has not been selected.  {0} is the default tool for {1}, would you like to update using that?"
        Friend Const SwitchingToSteamCMD = "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + vbCrLf + "IMPORTANT" + vbCrLf + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + vbCrLf + vbCrLf + "You are switching to SteamCMD from HLDSUpdateTool using the same directory.  SteamCMD WILL OVERWRITE ALL FILES in the game directory the first time it is used.  It is recommended that you create a new server and copy the files you need into the new directory to avoid issues.  Please make sure to BACK UP your game server before proceeding."

        Friend Const SrcdsGameDirectoryInUse = "This srcds.exe game directory is already in use by server {0}. Please create a new directory for a new server. Each game server much have its own directory."
        Friend Const CouldNotDetectGameServer = "Could not detect the game server. Please make sure the game is supported by seDirector and that the game server directory contains all the necessary files needed to run the game server."
        Friend Const DirectorySyncFieldMissing = "Enable Directory Sync is checked but there's a field missing information. Check the fields in the middle of the Optimization tab."
        Friend Const FTPSyncFieldMissing = "Enable FTP Synchronization is checked but there's a field missing information. Check the fields at the bottom of the Optimization tab."
        Friend Const FillInEmailNotification = "Please fill in the notification e-mail address or uncheck the 'Enable E-mail Notifications' checkbox."
        Friend Const FillInDiscordNotification = "Please fill in the Discord webhook or uncheck the 'Enable Discord Notifications' checkbox."
        Friend Const GameRequiresLoginToUpdate = "This game requires a login to update it. Please set the Steam login in Tools->Options or updating will fail."
        Friend Const InstallMetamodSourcemodBeforePlugin = "You must install Metamod + SourceMod before installing the seDirector plugin."

        Public Class ProcessPriority
            Friend Const Realtime = "Realtime"
            Friend Const High = "High"
            Friend Const AboveNormal = "Above normal"
            Friend Const Normal = "Normal"
            Friend Const BelowNormal = "Below normal"
            Friend Const Low = "Low"
        End Class

        Public Class Logs_ServerProperties
            Friend Const ModifiedServerProperties = "Modified server properties"
        End Class
    End Class

    Public Class UpdateProgress
        'Text for the progress of an update
        Friend Const StartUpdate = "StartUpdate"
        Friend Const Working = "Working"
        Friend Const UpdateComplete = "UpdateComplete"
        Friend Const Manual = "Manual"
    End Class

    Public Class Logs
        Friend Const StartServerBegin = "Starting server"
        Friend Const StartServerStartingError = "Starting server starting error"
        Friend Const StartServerFinished = "Running"
        Friend Const StartServerError = "Starting server error"

        Friend Const StopServerBegin = "Stopping server"
        Friend Const StopServerFinished = "Stopped"
        Friend Const StopServerError = "Stopping server error"

        Friend Const RestartServerBegin = "Restarting server"
        Friend Const RestartServerFinished = "Restarted"
        Friend Const RestartServerError = "Restarting server error"

        Friend Const UpdateServerBegin = "Started update process"
        Friend Const UpdateServerStartSuccess = "Updating server"
        Friend Const UpdateServerErrorExited = "Updating server error (exited)"
        Friend Const UpdateServerError = "Updating server error"

        Friend Const ShowHideError = "Show/Hide error"

        Friend Const CannotStartServerMissingDirectory = "Cannot start: Server directory missing"
    End Class

    Public Class FileProperties

        Public Class Logs_FileProperties
            Friend Const Title = "seDirector Log File"
            Friend Const Description = "Server log in chronological order."
            Friend Const Format = "MM/DD/YYYY HH:MM:SS AP | Event"
            Friend Const DescriptionFormat = "{0}: {1}"
            Friend Const DescriptionLabel = "Description"
            Friend Const ServerName = "Server Name"
            Friend Const ServerNameFormat = "{0}: {1}"
            Friend Const Game = "Game"
            Friend Const GameFormat = "{0}: {1}"
        End Class

    End Class

    Public Class Paths

        Public Class Names
            Friend Const ServerLogsFolder = "Server Logs"
            Friend Const seDirectorLogPath = "seDirector_error.log"
            Friend Const HLDSUpdateToolName = "HldsUpdateTool.exe"
            Friend Const SteamCMDName = "steamcmd.exe"
        End Class

        Public Class Formats
            Friend Const ServerLogsPath = "{0}\{1}"
            Friend Const ServerLogsHostPath = "{0}\{1}\{2}"
            Friend Const ServerLogsHostServerPath = "{0}\{1}\{2}\{3}.log"

            Friend Const seDirectorLogPath = "{0}\{1}"
        End Class

        Public Class InternalNames
            Friend Const ServerLogsPath = "ServerLogsPath"
            Friend Const ServerLogsHostPath = "ServerLogsHostPath"
            Friend Const ServerLogsHostServerPath = "ServerLogsHostServerPath"

            Friend Const seDirectorLogPath = "seDirectorLogPath"

            Friend Const SteamCMD = "SteamCMD"
            Friend Const HLDSUpdateTool = "HLDSUpdateTool"
        End Class

    End Class

    Public Class Addons
        Public Class AddonNames
            Friend Const SourceMod = "SourceMod"
            Friend Const MetamodSource = "Metamod:Source"
        End Class

        Public Class Errors
            Friend Const MustInstallMetamodBeforeSourcemod = "Please install Metamod:Source before installing SourceMod."
            Friend Const MustInstallUlibBeforeUlx = "Please install ulib before installing ulx."
            Friend Const ErrorInstaller = "Error 1009: An error occurred while attempting to {0} the addon."
            Friend Const ErrorInstallingUpdatingAddon = "Error while installing/updating addon."
            Friend Const ErrorChangingAddon = "There was an error while changing the addon. You may need to uninstall and reinstall the addon, or if having problems, restore from the backup file in addons\[Backups]."
            Friend Const ErrorChangingAddon2 = "Error while changing addon."
            Friend Const ErrorRemovingMetaMod = "Error while removing Metamod:Source:"
            Friend Const ErrorRemovingUlx = "Error while removing ulx"
            Friend Const ErrorRemovingUlib = "Error while removing ulib"
            Friend Const ErrorRemovingWiremod = "Error while removing wiremod"
        End Class

        Public Class Notifications
            Friend Const BackupNotify = "Because this is {0} {1}, a backup of the {2} directory will be made."
            Friend Const BackupAsk = "{0} {1} {2} {3}?"
        End Class

        Public Class Other
            Friend Const ChangingAddon = "Changing Addon"
            Friend Const ChangingMetamodSource = "Changing Metamod:Source version"
            Friend Const ChangingSourceModVersion = "Changing SourceMod version"
            Friend Const CreatingBackup = "Creating Backup"
            Friend Const BackingUp = "Backing up {0}"
        End Class
    End Class

    Public Class Donate
        Friend Const AutoClosingWindow = "Automatically closing this window in {0} seconds"
    End Class
End Class