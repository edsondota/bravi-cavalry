Bravi Cavalry
=============

An asp net core and angular application for Bravi assesment.


## Asp net core application


### Development mode

To run in debug mode:

```
cd knight-moves-api
code .
```

Then, in Visual Studio Code press F5 to start the application.


### Docker

To run a container:
```
cd knight-moves-api
docker build -t knight-moves-api .
docker run -d -p 8080:80 --name knight-moves-app knight-moves-api
```

or simple `docker-compose up` and `docker-compose down`.


### Tests

Go to test project folder and run:

```
cd knight-moves-api.Tests
dotnet test
```


## Angular App

### Development mode

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
```


or simple `docker-compose up` and `docker-compose down`.
