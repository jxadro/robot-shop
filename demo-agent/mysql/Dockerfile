FROM mysql:5.7.30

VOLUME /data

ENV MYSQL_ALLOW_EMPTY_PASSWORD=yes \
    MYSQL_DATABASE=sample \
    MYSQL_USER=shipping \
    MYSQL_PASSWORD=secret

# change datadir entry in /etc/mysql/my.cnf
COPY config.sh /root/
COPY myconf.cnf /etc/mysql/conf.d/

RUN /root/config.sh

COPY scripts/* /docker-entrypoint-initdb.d/

