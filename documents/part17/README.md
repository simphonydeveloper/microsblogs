## SqlCMD backup  simphony local database

Sometimes we encounter some tricky customers who are not allowed to install extra things on their computers. When you need to connect to a database to view some data, this is a tricky problem.

So today we will backup the database in a way that does not require installation, and after the backup is completed, it can be restored on our own host.

let's go.

**First, run the terminal in administrator mode**

input command.

```shell
SqlCmd -S localhost,yourdbport -U dbuserName -P yourdbpassword -Q "BACKUP DATABASE CheckPostingDB TO DISK='C:\Backup\CheckPostingDB.bak'"
```

output same content mean successful.

```shell
Processed 6880 pages for database 'CheckPostingDB', file 'CheckPostingDB' on file 2.
Processed 2 pages for database 'CheckPostingDB', file 'CheckPostingDB_log' on file 2.
BACKUP DATABASE successfully processed 6882 pages in 0.310 seconds (173.413 MB/sec).
```

