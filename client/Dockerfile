# for production we give name as build 
FROM node:20.1.0 as build

# Set working directory to /app 
WORKDIR /app

# Copy package.json to /app
COPY package*.json .

# copy dependencies
COPY . .

# run npm install to install dependencies
RUN npm install

# for production 
RUN npm run build

# pull nginx image from docker hub
FROM nginx:1.25.3 

# copy build folder to nginx folder
COPY --from=build /app/dist /usr/share/nginx/html

# default port for nginx is 80
EXPOSE 80

CMD [ "nginx","-g","daemon off;" ]