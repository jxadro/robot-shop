FROM websphere-liberty:full-java11-openj9


ADD ./*.war /opt/ibm/wlp/usr/servers/defaultServer/dropins/
ADD ./server.xml /config
ADD ./jvm.options /config

ENV PORT 9080
EXPOSE 9080


