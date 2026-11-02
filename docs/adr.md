## ADR
1. Szkieletem aplikacji bedzie modulowy monolit
    - kontekst - aplikacja posiada wyrazne granice doemnowe, wydzielenie modulow daje mozliwosc latwiejszego utrzymania i rozwoju projektu
    - decyzja - moduly: bookings, trips, users. Wpsolna baza i docker-compose
    - konsekwencje - architektura bardziej zlozona od kalsycznego monolitu
2. Rezygnacja z MediatR