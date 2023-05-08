#STAGE 1
FROM node:20-alpine AS build
WORKDIR /usr/src/app
COPY Frontend/package.json Frontend/package-lock.json .
RUN npm install
COPY Frontend/. .
RUN npm run build

#STAGE 2
FROM nginx:1.17.1-alpine
COPY Frontend/nginx.conf /etc/nginx/nginx.conf
COPY --from=build /usr/src/app/dist/frontend /usr/share/nginx/html