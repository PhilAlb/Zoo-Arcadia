#!/bin/bash

SOLUTION_DIR="Arcadia-front"

git checkout demo
cd "$SOLUTION_DIR" || exit
npm install
cd ..
./launch_scripts.sh
