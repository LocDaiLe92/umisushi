## Context

The UmiSushi menu page currently renders all items in a single-column plain list. Section headings are simple `<h2>` tags with a border-bottom, and item cards are stacked flex rows with name on the left and price on the right. A small thumbnail was recently added beside each section heading, but the overall feel remains generic and does not match the premium visual identity of the restaurant.

Reference designs show three established patterns for upscale restaurant menus:
1. **Editorial with floating images** — food photography floats beside a column of items (Oshiki reference)
2. **Two-column grid** — items split into two columns per section (Sushi Menu reference)
3. **Alternating image/list rows** — image on left one row, right the next (Sashimi/Nigiri reference)

Current tech stack: Blazor WASM, Tailwind CDN (limited override capability), custom `app.css`, static `MenuDataService`, existing thumbnail images in `/images/menu/`.

## Goals / Non-Goals

**Goals:**
- Make each menu section feel like a page from a premium printed menu
- Float section images beside item lists rather than as inline thumbnails in the heading
- Present items in a two-column grid on desktop (≥768px), single column on mobile
- Style item rows with name + dotted leader line + price on the same row
- Give section titles a decorative treatment (accent line, serif weight, generous spacing)
- Apply a warm cream/off-white background to the menu page content area
- Ensure all changes are CSS/Razor only — no data model changes

**Non-Goals:**
- Changing menu data, prices, or allergen logic
- Adding new menu categories or items
- Changing the sticky tab bar behavior or scroll-spy
- Animations or JS interactions beyond existing scroll-spy

## Decisions

### D1: Floating image layout — CSS float vs. CSS Grid

**Decision**: Use CSS `float: right` on the section image within the section block, rather than a grid layout.

**Rationale**: `float` naturally causes text/item columns to wrap around the image without needing to restructure the Razor component. The item list rendered by `@foreach` flows naturally around the floated image. A grid approach would require wrapping the item list in a container, complicating the Razor template significantly.

**Alternative considered**: CSS Grid with `grid-template-areas` — rejected because it requires the image and item list to be siblings at the same level, which means changing how `MenuSectionBlock` renders its children.

---

### D2: Two-column item grid — CSS columns vs. CSS Grid

**Decision**: Use `columns: 2` (CSS multi-column) on the items container, rather than `display: grid`.

**Rationale**: Multi-column naturally balances items across two columns without needing to know the item count. Works seamlessly with the existing `@foreach` loop and requires no Razor changes — only a CSS class on the items wrapper.

**Alternative considered**: `display: grid; grid-template-columns: 1fr 1fr` — would require even item counts per column and can produce awkward orphans.

---

### D3: Dotted leader line — pure CSS vs. JS

**Decision**: Pure CSS using `border-bottom: dotted` on a flex-grow spacer `<span>` between item name and price.

**Rationale**: Classic printed-menu look, zero JS, no accessibility concerns.

---

### D4: Section background texture

**Decision**: Apply `background-color: #faf8f4` (warm off-white cream) to `.menu-content-area` in `Menu.razor` only, rather than globally.

**Rationale**: Keeps the cream tint scoped to the menu page without affecting other pages.

## Risks / Trade-offs

- **Tailwind CDN conflicts**: Tailwind resets may interfere with `columns` or `float`. Mitigation: add `!important` where Tailwind overrides are detected.
- **Uneven column balance on short sections**: Multi-column can leave one column nearly empty for sections with 2-3 items. Mitigation: apply two-column only when section has ≥6 items, otherwise single column.
- **Float + scroll-margin-top**: The floated image increases section height; `scroll-margin-top` on the section wrapper already accounts for navbar + tab bar so this is fine.
- **Image availability**: Not all sections have images. Sections without images fall back to the plain heading + single-column layout automatically.
