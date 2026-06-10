## ADDED Requirements

### Requirement: Reservationssiden viser kontaktinfo til booking
Systemet SHALL vise restaurantens telefonnummer (86898087) og e-mail (info@umisushi.dk) som primær reservationsmetode med klikbare links (tel: og mailto:).

#### Scenario: Telefonnummer er klikbart
- **WHEN** brugeren klikker telefonnummeret på mobil
- **THEN** åbnes opkaldsdialog til 86898087

#### Scenario: E-mail er klikbar
- **WHEN** brugeren klikker e-mailadressen
- **THEN** åbnes standard mail-klient med info@umisushi.dk som modtager

### Requirement: Reservationsformular til forespørgsel
Systemet SHALL vise en simpel kontaktformular med felterne: Navn (required), Telefon/e-mail (required), Dato (required), Antal personer (required), Særlige ønsker (optional). Formularen SHALL validere required-felter før indsendelse.

#### Scenario: Formular validerer tomme felter
- **WHEN** brugeren forsøger at indsende formularen med tomme required-felter
- **THEN** vises valideringsfejlmeddelelser på de berørte felter

#### Scenario: Vellykket indsendelse viser bekræftelse
- **WHEN** brugeren indsender en korrekt udfyldt formular
- **THEN** vises en bekræftelsesbesked: "Tak for din forespørgsel! Vi vender tilbage hurtigst muligt."

### Requirement: Åbningstider vises på reservationssiden
Systemet SHALL vise restaurantens åbningstider på reservationssiden som kontekst for hvornår reservation er mulig.

#### Scenario: Åbningstider er synlige
- **WHEN** reservationssiden er indlæst
- **THEN** vises åbningstider for alle ugedage inkl. lukkedage og køkkenlukketid
