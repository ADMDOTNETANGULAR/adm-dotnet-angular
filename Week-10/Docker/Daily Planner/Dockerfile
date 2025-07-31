# Use Nginx as base image
FROM nginx:alpine

# Remove default nginx static files
RUN rm -rf /usr/share/nginx/html/*

# Copy your HTML project into nginx html directory
COPY . /usr/share/nginx/html

# Expose port 80
EXPOSE 80
