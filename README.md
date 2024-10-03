# MSTutorial_Pluszpont

Ez a repository tartalmazza a file-jait illetve dokumentaciojat a Szerveroldali alkalmazasok opcionalis 10 pontos feladatnak.

# Adatbazis

A megkezdeshez szukseges parancsok, amit ki kellett adnom az adatbazis feltelepitesehez (Nobara rendszeren):

```
sudo dnf install postgresql-server postgresql-contrib
sudo systemctl enable postgresql
sudo postgresql-setup --initdb --unit postgresql
sudo systemctl start postgresql
```

Felhasznalok es adatbazis letrehozasa:
```
sudo -u postgres psql
```
```
postgres=# CREATE USER golddeniel WITH PASSWORD 'admin';
postgres=# CREATE DATABASE GAMF OWNER golddeniel;
postgres=# \password admin
```
```
psql GAMF

firewall-cmd --permanent --add-port=5432/tcp
firewall-cmd --add-port=5432/tcp

```

A dotnet fel van alapbol telepitve nalam, mivel mas projektekhez szuksegem volt ra, annak a telepiteset ide nem irom le.

# Projekt letrehozasa
```
dotnet new mvc -o MvcMovie
```
```
dotnet dev-certs https --trust
```
Majd lefuttatom az templatet:
```
dotnet build
dotnet run
```
$${\color{green}Success}$$

