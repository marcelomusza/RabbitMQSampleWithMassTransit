# RabbitMQSample

## Overview
This repository contains a .NET solution demonstrating a basic publisher/subscriber pattern using RabbitMQ as a message broker. It includes three console applications: one publisher and two consumers, all dockerized with Docker Compose.

## Project Structure
- Publisher: A .NET console application for publishing messages to RabbitMQ.
- Consumer1: A .NET console application consuming messages from RabbitMQ.
- Consumer2: Another .NET console app that consumes messages from RabbitMQ.
- Dockerfiles for containerizing the applications.
- docker-compose.yml for orchestrating the services with RabbitMQ.

## Prerequisites
- .NET 8 SDK
- Docker Desktop

## Getting Started
1. Clone the repository.
2. Navigate to the cloned directory.
3. Build the Docker images using `docker-compose build`.
4. Run the services using `docker-compose up`.
5. To stop the services, use `docker-compose down`.

## Configuration
The publisher and consumers are configured to connect to RabbitMQ using the hostname defined in docker-compose.yml.

## Troubleshooting
- Ensure Docker is operational before executing commands.
- For running outside Docker, switch RabbitMQ host in connection strings to 'localhost'.

## Contributing
Feel free to contribute to this project. Open an issue for major changes to discuss first.

## License
MIT License
