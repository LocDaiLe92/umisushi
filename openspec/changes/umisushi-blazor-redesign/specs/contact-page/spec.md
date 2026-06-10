## ADDED Requirements

### Requirement: Kontaktsiden viser komplet kontaktinformation
Systemet SHALL vise restaurantens adresse, telefonnummer og e-mail med klikbare links.

#### Scenario: Kontaktinfo er klikbar
- **WHEN** kontaktsiden er indlæst
- **THEN** vises adresse, klikbart telefonnummer (tel:86898087) og klikbar e-mail (mailto:info@umisushi.dk)

### Requirement: Google Maps embed viser restaurantens placering
Systemet SHALL vise et Google Maps iframe-embed der viser restaurantens placering i Ry.

#### Scenario: Kort er indlæst
- **WHEN** kontaktsiden er indlæst
- **THEN** vises et interaktivt Google Maps-kort med restaurantens pin

### Requirement: Åbningstider vises på kontaktsiden
Systemet SHALL vise den komplette åbningstidstabel: Mandag lukket, Tirsdag-Fredag 16:00-21:00, Lørdag 12:00-21:00, Søndag 16:00-20:00, med note om køkkenet lukker 30 min. før lukketid.

#### Scenario: Åbningstidstabel er korrekt
- **WHEN** kontaktsiden er indlæst
- **THEN** vises alle ugedage med korrekte tidspunkter og lukkedag markeret tydeligt

### Requirement: Findsmiley-badge vises
Systemet SHALL vise en ekstern Findsmiley-badge/link (findsmiley.dk/635610) som dokumentation for restaurantens smileyrapport.

#### Scenario: Findsmiley-link er tilgængeligt
- **WHEN** kontaktsiden er indlæst
- **THEN** vises Findsmiley-badge der linker til findsmiley.dk/635610 i nyt faneblad
