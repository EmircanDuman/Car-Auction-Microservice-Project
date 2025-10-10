A complete mock Car Auction web application implemented as a microservice application

.NET Framework | Microservices | PostgreSQL | MongoDB | Entity Framework | HTTP | gRPC | SignalR | RabbitMQ | Docker | OAuth2

- Identity Service implemented with Duende Identity Service
- Auction Service / Seach Service / Bidding Service / Notification Service are implemented as seperate dockerized applications
- Communication between seperate services done with RabbitMQ
- Gateway Service was created for reverse proxying
- SignalR for sending notifications to frontend
- Nginx for ingress
- Postgresql and MongoDB for services
- HTTP + gRPC connections
