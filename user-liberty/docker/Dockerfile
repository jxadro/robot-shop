FROM websphere-liberty:full-java11-openj9


ADD ./*.war /opt/ibm/wlp/usr/servers/defaultServer/dropins/
ADD ./server.xml /config

ENV PORT 8080
EXPOSE 8080


