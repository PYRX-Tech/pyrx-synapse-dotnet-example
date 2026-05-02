#!/usr/bin/env bash
set -uo pipefail
RED='\033[0;31m'; GREEN='\033[0;32m'; NC='\033[0m'
PASS=0; FAIL=0

[[ -z "${SYNAPSE_API_KEY:-}" ]] && echo "Set SYNAPSE_API_KEY" && exit 1

cd "$(dirname "$0")"

echo "Building..."
dotnet build > /dev/null 2>&1

run_script() {
  local name="$1"
  if dotnet run --no-build -- "$name" > /dev/null 2>&1; then
    echo -e "  ${GREEN}✓${NC} $name"
    ((PASS++)) || true
  else
    echo -e "  ${RED}✗${NC} $name"
    ((FAIL++)) || true
  fi
}

echo "Running all scripts..."

echo "── Core ──"
run_script "track_event"
run_script "track_batch"
run_script "identify_contact"
run_script "identify_batch"
run_script "send_email"

echo "── Contacts ──"
run_script "contacts_list"
run_script "contacts_get"
run_script "contacts_update"
run_script "contacts_delete"

echo "── Templates ──"
run_script "templates_list"
run_script "templates_get"
run_script "templates_create"
run_script "templates_update"
run_script "templates_preview"
run_script "templates_delete"

echo ""
echo "Results: $PASS passed, $FAIL failed"
[[ $FAIL -eq 0 ]] && echo -e "${GREEN}All passed!${NC}" || echo -e "${RED}$FAIL failed${NC}"
exit $FAIL
