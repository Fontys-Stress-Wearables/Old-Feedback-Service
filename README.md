# Feedback-Service
## Port: 5033
The service that is responsible for handling feedback on stress measurements.
## API endpoints
```
/FeedbackEntries
```
## Docker
If you want to manually build a Docker container of this service and running, use the following commands in a CLI:
```
docker build -t feedback_service --name FeedbackService .
```
Then
```
docker run -p 5033:80 --network=swsp feedback_service
```
