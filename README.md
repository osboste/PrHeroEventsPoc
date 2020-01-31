# PrHeroEventsPoc

Running:
1) Run the API, capture the port number
2) Run ngrok locally to redirect the GitHub post to localhost: 
    - ngrok http https://localhost:44394 -host-header="localhost:44394"
    - replace the port number with port from 1)
3) Update the webhook in github to reflect the https:// address that ngrok configures
