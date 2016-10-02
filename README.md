# TS3QueryLib.Net.Core
This library allows you to query team speak 3 servers using the query port.  All queries are implemented type safe and the library is written to work with .Net Core.

This library is work in progress. A lot of commands are missing, but the notifications are complete.

**List of Command-Implementation-State** (&#x2714; implemented - &#x2716; not implemented yet):


* &#x2716; help
* &#x2714; quit
* &#x2714; login
* &#x2714; logout
* &#x2714; version
* &#x2714; hostinfo
* &#x2714; instanceinfo
* &#x2714; instanceedit
* &#x2714; bindinglist
* &#x2714; use
* &#x2714; serverlist
* &#x2714; serveridgetbyport
* &#x2714; serverdelete
* &#x2714; servercreate
* &#x2714; serverstart
* &#x2714; serverstop
* &#x2714; serverprocessstop
* &#x2714; serverinfo
* &#x2714; serverrequestconnectioninfo
* &#x2714; servertemppasswordadd
* &#x2714; servertemppassworddel
* &#x2714; servertemppasswordlist
* &#x2716; serveredit
* &#x2716; servergrouplist
* &#x2716; servergroupadd
* &#x2714; servergroupdel
* &#x2716; servergroupcopy
* &#x2714; servergrouprename
* &#x2716; servergrouppermlist
* &#x2714; servergroupaddperm
* &#x2714; servergroupdelperm
* &#x2716; servergroupaddclient
* &#x2716; servergroupdelclient
* &#x2716; servergroupclientlist
* &#x2716; servergroupsbyclientid
* &#x2716; servergroupautoaddperm
* &#x2716; servergroupautodelperm
* &#x2716; serversnapshotcreate
* &#x2716; serversnapshotdeploy
* &#x2716; servernotifyregister
* &#x2716; servernotifyunregister
* &#x2716; sendtextmessage
* &#x2716; logview
* &#x2716; logadd
* &#x2716; gm
* &#x2716; channellist
* &#x2716; channelinfo
* &#x2716; channelfind
* &#x2716; channelmove
* &#x2716; channelcreate
* &#x2716; channeldelete
* &#x2716; channeledit
* &#x2716; channelgrouplist
* &#x2716; channelgroupadd
* &#x2716; channelgroupdel
* &#x2716; channelgroupcopy
* &#x2716; channelgrouprename
* &#x2716; channelgroupaddperm
* &#x2716; channelgrouppermlist
* &#x2716; channelgroupdelperm
* &#x2716; channelgroupclientlist
* &#x2716; setclientchannelgroup
* &#x2716; tokenadd
* &#x2716; tokendelete
* &#x2716; tokenlist
* &#x2716; tokenuse
* &#x2716; channelpermlist
* &#x2716; channeladdperm
* &#x2716; channeldelperm
* &#x2716; clientlist
* &#x2716; clientinfo
* &#x2716; clientfind
* &#x2716; clientedit
* &#x2716; clientdblist
* &#x2716; clientdbinfo
* &#x2716; clientdbfind
* &#x2716; clientdbedit
* &#x2716; clientdbdelete
* &#x2716; clientgetids
* &#x2716; clientgetdbidfromuid
* &#x2716; clientgetnamefromuid
* &#x2716; clientgetuidfromclid
* &#x2716; clientgetnamefromdbid
* &#x2716; clientsetserverquerylogin
* &#x2716; clientupdate
* &#x2716; clientmove
* &#x2716; clientkick
* &#x2716; clientpoke
* &#x2716; clientpermlist
* &#x2716; clientaddperm
* &#x2716; clientdelperm
* &#x2716; channelclientpermlist
* &#x2716; channelclientaddperm
* &#x2716; channelclientdelperm
* &#x2716; permissionlist
* &#x2716; permidgetbyname
* &#x2716; permoverview
* &#x2716; permget
* &#x2716; permfind
* &#x2716; permreset
* &#x2716; privilegekeylist
* &#x2716; privilegekeyadd
* &#x2716; privilegekeydelete
* &#x2716; privilegekeyuse
* &#x2716; messagelist
* &#x2716; messageadd
* &#x2716; messagedel
* &#x2716; messageget
* &#x2716; messageupdateflag
* &#x2716; complainlist
* &#x2716; complainadd
* &#x2716; complaindelall
* &#x2716; complaindel
* &#x2716; banclient
* &#x2716; banlist
* &#x2716; banadd
* &#x2716; bandel
* &#x2716; bandelall
* &#x2716; ftinitupload
* &#x2716; ftinitdownload
* &#x2716; ftlist
* &#x2716; ftgetfilelist
* &#x2716; ftgetfileinfo
* &#x2716; ftstop
* &#x2716; ftdeletefile
* &#x2716; ftcreatedir
* &#x2716; ftrenamefile
* &#x2716; customsearch
* &#x2716; custominfo
* &#x2716; whoami
