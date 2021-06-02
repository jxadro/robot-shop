FROM websphere-liberty:javaee7


ADD ./*.war /opt/ibm/wlp/usr/servers/defaultServer/dropins/
ADD ./server.xml /config

ENV PORT 8080
EXPOSE 8080


