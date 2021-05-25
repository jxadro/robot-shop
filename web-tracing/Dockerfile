FROM nginx:1.19.7

EXPOSE 8080

ENV CATALOGUE_HOST=catalogue \
    USER_HOST=user \
    CART_HOST=cart \
    SHIPPING_HOST=shipping \
    PAYMENT_HOST=payment \
    RATINGS_HOST=ratings

COPY modules/nginx-1.19.7-ngx_http_ot_module.so /usr/lib/nginx/modules
COPY modules/libinstana_sensor.so /usr/local/lib/libinstana_sensor.so
COPY instana-config.json /etc/instana-config.json

COPY entrypoint.sh /root/
ENTRYPOINT ["/root/entrypoint.sh"]

COPY default.conf.template /etc/nginx/default.conf.template
COPY static /usr/share/nginx/html
