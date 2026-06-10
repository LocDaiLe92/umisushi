## 1. Menu Page Background

- [x] 1.1 Add `.menu-content-area` wrapper div in `Menu.razor` around the section list
- [x] 1.2 Add `.menu-content-area { background: #faf8f4; }` CSS to `app.css`

## 2. Section Heading Redesign

- [x] 2.1 Update `.menu-section-heading` in `app.css` — increase font-size, add red accent border-bottom treatment (2px solid `#e53935`), add more top padding
- [x] 2.2 Update `.menu-section-header` layout in `app.css` to remove the shared bottom border (individual heading now handles it)

## 3. Floating Section Image

- [x] 3.1 Rewrite `MenuSectionBlock.razor` — move section image to a `float: right` `<div>` inside the section wrapper, after the heading, before the items loop
- [x] 3.2 Add `.menu-section-float-img` CSS — `float: right`, `width: 200px`, `height: 150px`, `border-radius: 12px`, `box-shadow`, `margin: 0 0 1rem 1.5rem`, `overflow: hidden`
- [x] 3.3 Add `@media (max-width: 767px) { .menu-section-float-img { display: none; } }` to hide images on mobile
- [x] 3.4 Add clearfix after the items loop in `MenuSectionBlock.razor` (`<div style="clear:both"></div>`)

## 4. Two-Column Item Grid

- [x] 4.1 Wrap the `@foreach` items loop in `MenuSectionBlock.razor` with a `<div class="menu-items-grid @(Section.Items.Count >= 6 ? "two-col" : "")">`
- [x] 4.2 Add `.menu-items-grid.two-col { columns: 2; column-gap: 2rem; }` CSS
- [x] 4.3 Add `@media (max-width: 767px) { .menu-items-grid.two-col { columns: 1; } }` for mobile fallback
- [x] 4.4 Add `break-inside: avoid` to `.menu-item` so items don't split across columns

## 5. Dotted Leader Line on Item Cards

- [x] 5.1 Rewrite `MenuItemCard.razor` item name+price row to use a flex container with a `<span class="menu-item-leader">` spacer between name and price
- [x] 5.2 Add `.menu-item-leader { flex: 1; border-bottom: 2px dotted #ccc; margin: 0 0.4rem 0.2rem; align-self: flex-end; }` CSS
- [x] 5.3 Verify dotted line only appears when a price is present

## 6. Visual QA

- [x] 6.1 Test desktop layout — floating image, two columns, leader lines all render correctly
- [x] 6.2 Test mobile layout — single column, images hidden, leader lines still visible
- [x] 6.3 Verify scroll-spy and tab bar still work after Razor structure changes
- [x] 6.4 Check short sections (< 6 items) render in single column without float awkwardness
