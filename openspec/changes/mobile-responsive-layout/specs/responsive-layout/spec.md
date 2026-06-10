## ADDED Requirements

### Requirement: No horizontal overflow on mobile

The site SHALL NOT produce horizontal page overflow at any viewport width from 320px upward. No section, card, image, or embedded element may extend beyond the viewport width or introduce a horizontal scrollbar on the document body.

#### Scenario: Home page at 320px width

- **WHEN** the home page is viewed at a 320px-wide viewport
- **THEN** the document body produces no horizontal scrollbar
- **AND** every section's content stays within the viewport edges

#### Scenario: Media never exceeds viewport

- **WHEN** any page containing images or embeds is viewed on a mobile viewport
- **THEN** each image and embed is constrained to at most 100% of its container width

### Requirement: Multi-column sections collapse on small screens

Multi-column layouts SHALL collapse to a single column at or below the mobile breakpoint so content remains readable without horizontal scrolling. Column counts MUST be controlled by reusable CSS classes (not inline `grid-template-columns` styles) so that media queries can override them.

#### Scenario: Social-media card row stacks on mobile

- **WHEN** the "Find os på sociale medier" section is viewed at 480px width or below
- **THEN** the Facebook, Instagram, and TripAdvisor cards stack in a single column
- **AND** each card's text stays inside the card boundary

#### Scenario: Opening-hours and intro columns stack on mobile

- **WHEN** a two-column section (e.g. opening hours, intro split) is viewed at the mobile breakpoint
- **THEN** the two columns stack vertically in a single column
- **AND** the inter-column gap collapses to a mobile-appropriate spacing

### Requirement: Responsive layout uses reusable utility classes

Section layouts that need to respond to viewport size SHALL be defined through named CSS classes in the stylesheet rather than inline grid styles, so responsive behaviour is centralized and overridable.

#### Scenario: Grid container is class-driven

- **WHEN** a responsive multi-column section is rendered
- **THEN** its column configuration is provided by a CSS class
- **AND** no inline `grid-template-columns` style blocks the stylesheet's media-query override
