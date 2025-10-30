# Mobile ERP UI Spec (MAUI)

## Overview
MAUI.NET mobile template for ERP systems using blue/white theme and native patterns.

## Technical Specs
- **Framework**: .NET MAUI 9.0+
- **Platform**: Android 8.0+ (API 26)
- **Navigation**: Shell with Bottom Tabs
- **Theme**: Light

## Device Support

| Category | Representative Devices | Screen Size |
|----------|----------------------|-------------|
| **Small Phone** | Pixel 5, Galaxy S23 | 6.0" - 6.2" |
| **Medium Phone** | Galaxy S24, Pixel 8 | 6.3" - 6.6" |
| **Large Phone** | S24 Ultra, Pixel 8 Pro | 6.7" - 6.8" |
| **Foldable** | Z Fold5, Pixel Fold | 6.2" - 7.8" |
| **Small Tablet** | Tab A9+, Tab P11 | 8" - 11" |
| **Large Tablet** | Tab S9 Ultra, Pixel Tablet | 12.4" - 14.6" |

## Core Screens

### Dashboard
- Bottom Nav (5 items max)
- Header: Welcome + user name
- KPI Cards (3-col grid)
- FAB: "+ New"
- Recent Items list

### List View
- SearchBar + Filter
- CollectionView with:
  - Primary text (bold)
  - 2 secondary lines
  - Status dot + chevron

### Detail View
- Header: Title + ID
- VerticalStackLayout sections
- Sticky footer: Primary action + menu

### Data Entry
- VerticalStackLayout form
- Entry fields + Pickers
- Scan Barcode button
- Submit/Cancel actions

## Design System

### Colors
- Primary: #2196F3
- Background: #FAFAFA
- Text: #212121 / #757575
- Status: Green/Orange/Red

### Typography
- Headers: 20pt Bold
- Body: 16pt Regular
- Labels: 14pt SemiBold

### Components
- Touch target: 44pt min
- Border radius: 8pt
- Standard padding: 16pt

## Acceptance
- [ ] All screens render correctly
- [ ] Bottom nav works
- [ ] FAB triggers primary action
- [ ] Search filters in real-time
- [ ] Theme matches blue/white
- [ ] 44pt touch targets