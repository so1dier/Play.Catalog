## How to run docker for mongo db database and expose port 27017 and a storage volume "mongodbdata:/data/db"
```bash
docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo
```

## How to run the main project
'''bash
dotnet run
'''