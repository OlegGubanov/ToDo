FROM postgres:latest
ENV POSTGRES_USER postgres
ENV POSTGRES_PASSWORD password
ENV POSTGRES_DB tododb
COPY dump.sql /docker-entrypoint-initdb.d/