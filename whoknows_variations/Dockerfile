# Use the official Python image from the Docker Hub
FROM python:3.9-slim

# Install make and other necessary build tools
RUN apt-get update && \
    apt-get install -y --no-install-recommends \
    make \
    && rm -rf /var/lib/apt/lists/*

# Set environment variables
ENV PYTHONDONTWRITEBYTECODE 1
ENV PYTHONUNBUFFERED 1

# Create and set the working directory
WORKDIR /app

# Copy the Makefile and requirements file
COPY src/Makefile /app/src/
COPY src/backend/requirements.txt /app/src

# Install dependencies
RUN pip install --no-cache-dir -r /app/src/requirements.txt

# Copy the rest of the application code
COPY . /app/

# Default command to run
CMD ["make", "-C", "src", "run"]
