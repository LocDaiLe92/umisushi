## ADDED Requirements

### Requirement: Hero-sektion vises ved sideindlæsning
Systemet SHALL vise en fuldskærms hero-sektion øverst på forsiden med restaurantens navn, en tagline og to primære CTA-knapper: "Book et bord" og "Se menuen". Hero-baggrunden SHALL bruge et høj-kvalitets billede af sushi med et mørkt overlay.

#### Scenario: CTA-knapper navigerer korrekt
- **WHEN** brugeren klikker "Book et bord"
- **THEN** systemet navigerer til `/reservation`

#### Scenario: CTA-knapper navigerer korrekt – menu
- **WHEN** brugeren klikker "Se menuen"
- **THEN** systemet navigerer til `/menu`

### Requirement: Om-restauranten sektion præsenterer UmiSushi
Systemet SHALL vise en sektion med tekst om restauranten ("I hjertet af Ry..."), inkl. mention af indendørs og udendørs siddepladser i gårdhaven.

#### Scenario: Om-tekst er synlig
- **WHEN** brugeren scroller til om-sektionen
- **THEN** vises restaurantbeskrivelse og et stemningsbillede

### Requirement: Highlights-sektion viser 3 nøglekvaliteter
Systemet SHALL vise en sektion med 3 highlights: "Frisk sushi", "Hyggelig atmosfære", "Take-away tilgængeligt" repræsenteret som ikoner + tekst.

#### Scenario: Highlights vises korrekt
- **WHEN** forsiden loades
- **THEN** vises tre highlights i en grid-/row-layout

### Requirement: Åbningstider vises på forsiden
Systemet SHALL vise en komprimeret visning af restaurantens åbningstider direkte på forsiden.

#### Scenario: Åbningstider er synlige
- **WHEN** forsiden er indlæst
- **THEN** vises åbningstider for alle ugedage inkl. note om køkkenlukketid 30 min. før lukketid

### Requirement: Opfordring til take-away bestilling
Systemet SHALL vise en sektion med CTA til take-away bestilling der linker til weorder.xyz/umisushi.

#### Scenario: Take-away CTA er klikbar
- **WHEN** brugeren klikker take-away CTA
- **THEN** åbnes weorder.xyz/umisushi i nyt faneblad

### Requirement: TripAdvisor-anmeldelselink
Systemet SHALL vise et link til restaurantens TripAdvisor-side med teksten "Se hvad gæsterne siger om os".

#### Scenario: TripAdvisor-link åbner eksternt
- **WHEN** brugeren klikker linket
- **THEN** åbnes TripAdvisor-siden i nyt faneblad
