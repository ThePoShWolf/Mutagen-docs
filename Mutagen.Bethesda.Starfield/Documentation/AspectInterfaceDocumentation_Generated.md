# Aspect Interfaces
Aspect Interfaces expose common aspects of records.  For example, `INamed` are implemented by all records that have a `Name`.

Functions can then be written that take in `INamed`, allowing any record that has a name to be passed in.
## Interfaces to Concrete Classes
### IKeywordCommon
- Keyword
### IModeled
- Weapon
### INamed
- ActionRecord
- Keyword
### IPositionRotation
- Transform
## Concrete Classes to Interfaces
### ActionRecord
- INamed
### Keyword
- IKeywordCommon
- INamed
### Transform
- IPositionRotation
### Weapon
- IModeled
