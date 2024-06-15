## Docker run
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d --remove-orphans
## Docker build and run
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d --build --remove-orphans


# Docker Application URLs - LOCAL Enviroment (Docker Container):
- Portainer: http://localhost:9000   -  user: admin  ; pass: admin12345678
- Kibana: http://localhost:5601 - user: elastic ; pass: admin
- RabbitMQ: http://localhost:15672  - user: guest; pass: guest

## Application Service Urls:
**Development Environment**

- Api Gateway: https://localhost:5510
- Identity Service: https://localhost:5001
- OctoQual API: https://localhost:5002
- OctoQual Client MVC: https://localhost:6001