## ADDED Requirements

### Requirement: Take-away siden linker til online bestillingssystem
Systemet SHALL vise en prominerende CTA der linker til weorder.xyz/umisushi i nyt faneblad.

#### Scenario: Bestil nu-knap åbner eksternt system
- **WHEN** brugeren klikker "Bestil nu" / "Klik her og bestil nu"
- **THEN** åbnes http://weorder.xyz/umisushi i nyt faneblad

### Requirement: Take-away siden informerer om processen
Systemet SHALL vise information om take-away processen: bestilling online, afhentning i restauranten, kontaktinfo.

#### Scenario: Procedure er forklaret
- **WHEN** take-away siden er indlæst
- **THEN** vises en kort beskrivelse af take-away processen og afhentningsadresse

### Requirement: Take-away URL er konfigurerbar
Systemet SHALL definere take-away URL som en konfigurerbar konstant der kan opdateres ét sted i kodebasen.

#### Scenario: URL-konstant bruges konsistent
- **WHEN** take-away URL ændres i konfigurationsfilen
- **THEN** opdateres alle links til take-away systemet automatisk
