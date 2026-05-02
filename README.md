# Synapse .NET Example

All 15 SDK endpoints with [pyrx-synapse-dotnet](https://github.com/pyrx-tech/pyrx-synapse-dotnet).

## Setup

1. Ensure .NET 8.0+ SDK is installed
2. Copy `.env.example` to `.env` and fill in your credentials
3. Export environment variables: `export $(cat .env | xargs)`

## Examples

### Core
```bash
dotnet run -- track_event         # Track event
dotnet run -- track_batch         # Batch track
dotnet run -- identify_contact    # Identify contact
dotnet run -- identify_batch      # Batch identify
dotnet run -- send_email          # Send email
```

### Contacts
```bash
dotnet run -- contacts_list       dotnet run -- contacts_get
dotnet run -- contacts_update     dotnet run -- contacts_delete
```

### Templates
```bash
dotnet run -- templates_list      dotnet run -- templates_get
dotnet run -- templates_create    dotnet run -- templates_update
dotnet run -- templates_delete    dotnet run -- templates_preview
```

## Test

```bash
export SYNAPSE_API_KEY=psk_live_...
export SYNAPSE_WORKSPACE_ID=ws_...
bash test.sh
```

- [Synapse Docs](https://synapse.pyrx.tech/developers)
- [.NET SDK](https://synapse.pyrx.tech/developers/sdks/dotnet)
