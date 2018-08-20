Bravi Cavalry
=============

An asp net core and angular application for Bravi assesment.


## Asp net core application


### Devlopment mode

To run in debug mode:

```
cd knight-moves-api
code .
```

Then, press F5.


### Docker

To run a container:
```
cd knight-moves-api
docker build -t knight-moves-api .
docker run -d -p 8080:80 --name knight-moves-app knight-moves-api
```


### Tests

Go to test project folder and run:

```
cd knight-moves-api.Tests
dotnet test
```


## Angular App

### Devlopment mode

To run in development mode:
```
cd angular-chessboard
ng serve --open
```


### Docker

To run a container:

```
ng build --prod
docker build -t angular-chessboard .
docker run -d -p 3000:80 --name angular-chessboard angular-chessboard
