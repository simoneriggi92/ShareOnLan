# ShareOnLan

ShareOnLan è una Windows Dekstop Application che consente di inviare file o cartelle
tra due o più computer sfruttando la rete LAN come mezzo di trasmissione.
È stata implementata come soluzione per il progetto del corso di Programmazione di Sistema dell'a.a 2016/2017 tenuto dai prof. Giampiero Cabodi e Giovanni Malnati al Politecnico di Torino,
per il Corso di Laurea Magistrale in INGEGNERIA INFORMATICA (COMPUTER ENGINEERING).

# Specifiche del sistema richieste

  - Il servizio di sharing, messo in esecuzione in background, consente di annunciare la
disponibilità del proprio host a tutti gli altri host presenti nella rete locale. Per scoprire la
presenza di tali host, potrà essere utilizzato un meccanismo basato sull’uso di pacchetti UDP
multicast o tecnologie simili.
  - Un host può essere configurato in modalità privata: in tal caso non rivelerà agli altri host la sua presenza e non potrà ricevere alcun file. Potrà però inviarli. Un host configurato in modalità pubblica, invece, annuncia la propria presenza, e consente di accettare file provenienti da altri computer della rete, comportandosi da server. Se l’utente di un host seleziona il menu contestuale (tasto destro) su un file o su una cartella,
vede apparire una voce che gli consente di condividere il file o la cartella a tutti gli host che si sono annunciati o solo a un loro sottoinsieme. In questo caso l’host si comporta da client.
La connessione tra i diversi host coinvolti nel trasferimento sarà basata su un protocollo di
rete a piacere.
- Bisognerà gestire i conflitti in caso di ricezione di più file con stesso nome da salvare sullo
stesso percorso.
- L’host che invia un file visualizza una barra di avanzamento, una stima del tempo di
completamento, e dà all’utente la possibilità di annullare l’operazione.

### Tecnologie utilizzate

* .NET Framework version 4.7.2
* C#
* Windows Form
* [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) - Theming .NET WinFormsto Google's Material Design Principles.

### Implementazione

Per l'implementazione delle specifiche richieste sono stati utilizzati:

* UDP Multicast - per annunciare gli host online
* TCP  - per l'invio di file e cartelle tra gli host
* Multithreading (BackgroundWorkers, Threads)
* Windows Form - per la realizzazione dell'UI. È stato utilizzato il pacchetto Nuget MaterialSkin per l'utilizzo del Material Design

## Autore

* **Simone Riggi** - simone.riggi92@gmail.com
