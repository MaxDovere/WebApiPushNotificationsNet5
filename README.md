# WebApiPushNotificationsNet5
Web Api Push Notification Net. 5.0 with WebPush - PushService

Requisiti Applicazione
Si richiede di ottenere una WebApp/ApiPush in modalità da aggregare al sito già esistente di Action (WebApp proprietaria) per Dealer AutoMotive. Di seguito si avrà una sintesi dell suo utilizzo ed eventuali requisiti atti all’installazione e alla efficacia attività che dovrà svolgere il servizio.

Descrizione
Sviluppata in Asp Net Core 5.0 MVC ed EntityFrameworkCore, l’applicazione sarà attiva in tre visualizzazioni che rappresentano le interfacce del servizio.

View Principale
Sarà necessario approntare una ista di check da svolgere per capire e registrare le seguenti attività:
•	Check sulla compatibilità del Browser per le API PUSH (proprietarie al Browser)
•	Check sulla compatibilità del Server Worker nel Browser
•	Check sui permessi per ottenere il consenso di eventuali notifiche in locale
•	Check di esistenza e registrazione del Server Worker in locale (notifica e attività sulle notifiche)

View Message Template
Sarà necessario approntare una pagina dove saranno evidenti tutti gli attributi del messaggio, usato come template, da poter usare e mandare in seguito sulla base degli obiettivi dello stesso messaggio. Ci saranno, probabilmente, tipi diversi di Template in base a Lead, Attività e Altro da inviare al cliente di Action.

View ApiPush / Swagger (deprecated)
Sarà necessario evidenziare tutte le API di cui il servizio è dotato in una forma esplicativa e di test usando la tecnologia Swagger se possibile ed in alternativa una lista di chiamate dove si comprenderanno i parametri di arrivo e di lancio delle stesse API.
Push Notifications come funzionano?
Si può estendere l’applicazione con un sottoinsieme applicativo chiamato API PUSH, esse sono all’interno del Browser – verificare il browser usato e i limiti. Dobbiamo capire come esse lavorano aiutandoci con l’immagine di seguito.

Architettura WebApp - Push Notificat1ion
•	Back-end : Database
•	Back-end : Notification Api controller
•	Front-end: Server-Worker: eventi “Push” – “NotificationClick”
•	Front-end: Scripts Js ServerWorker/PushNotification
•	Front-end: JS Controller WebApi (lato Client)

Database
	Sql Server 2019 – ORM EntityFrameworkCore – Net 5.0
Tables: 
PushSubsctriprionUser
	PushSubsctriprionTopics
PushTopics
PushMessageTemplate 
PushMessageActions -> 
PushMessageAction
	PushMessageType
	PushMessageUrgency
PushNotificationUser
Pages
•	Home Page / Check servizi
•	Message Template page: Creazione/Lettura/Modifica/Cancellazione (CRUD)
•	Api page: Lista API e parametri (Swagger/Custom)
Documentazione accessoria per comprendere le API PUSH
Bibbliografia
Windows 10 UI Notifications
https://docs.microsoft.com/en-us/previous-versions/windows/apps/hh868259(v=win.10)?redirectedfrom=MSDN
Badges notification
Push Notification
Toast Notification
Push API (w3.org)
w3c/push-api: Push API (github.com)
Notifications API Standard (whatwg.org)
RFC 8030 - Generic Event Delivery Using HTTP Push (ietf.org)
Toast to windows 10 – PowerShell
How To Show A Custom Toast Notification On Windows 10 (addictivetips.com)
Windos/BurntToast: Module for creating and displaying Toast Notifications on Microsoft Windows 10. (github.com) 
Service Workers: an Introduction  |  Web Fundamentals (google.com)
Service ADA (89) Webinar ITA: Push Notification - YouTube
