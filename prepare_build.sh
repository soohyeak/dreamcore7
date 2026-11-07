#!/bin/bash
set -e
BUILD_SRC="$1"; DEST="$2"; if [[ -z "$BUILD_SRC" || -z "$DEST" ]]; then echo 'Usage: prepare_build.sh <src> <dest>'; exit 1; fi
mkdir -p "$DEST"; cp -r "$BUILD_SRC"/* "$DEST"/; echo 'Copied build to' $DEST
