## 1. Stylesheet foundation

- [x] 1.1 Add a global overflow guard to `app.css`: `overflow-x: clip` and `max-width: 100%` on `html, body`, and a base `img { max-width: 100%; }` rule.
- [x] 1.2 Add a `.some-grid` utility class (3-column grid with `gap` matching the current inline value) that collapses to 1 column at `max-width: 640px`.
- [x] 1.3 Add a `.two-col` utility class (1fr 1fr grid) that collapses to a single column with reduced gap at `max-width: 768px`.

## 2. Home page conversion

- [x] 2.1 Replace the social-media row's inline `style="display:grid;grid-template-columns:repeat(3,1fr);gap:1.5rem;"` in `Home.razor` with `class="some-grid"`.
- [x] 2.2 Replace the opening-hours section's inline two-column grid with `class="two-col"`.
- [x] 2.3 Replace the intro/hjertet two-column grid with `class="two-col"` (or an appropriate variant), preserving current desktop spacing.
- [x] 2.4 Remove the now-redundant `.some-card { grid-column: span 1; }` mobile rule that targeted the wrong element.

## 3. Audit remaining pages

- [x] 3.1 Grep all Razor pages for inline `grid-template-columns` and list every occurrence.
- [x] 3.2 Convert matching inline grids in `Menu.razor`, `Contact.razor`, `Reservation.razor`, `TakeAway.razor`, and `SeasonalMenu.razor` to the responsive utility classes.

## 4. Verification

- [x] 4.1 Run the app and confirm no horizontal scrollbar appears on the home page at 320px, 375px, and 430px widths.
- [x] 4.2 Confirm the social-media cards and all two-column sections stack to a single column on mobile and text stays within bounds.
- [x] 4.3 Confirm the menu tab bar still scrolls horizontally inside its own container (global guard did not break it).
- [x] 4.4 Confirm desktop (≥1024px) layout is visually unchanged.
