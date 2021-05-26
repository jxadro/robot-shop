#!/usr/bin/env bash

set -eo pipefail

docker build -t on-prem-monitoring-endpoint-proxy .

docker run \
  --rm \
  --name on-prem-monitoring-endpoint-proxy \
  -p 2999:2999 \
  --network=host \
  --detach \
  on-prem-monitoring-endpoint-proxy
