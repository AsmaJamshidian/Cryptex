# Theoretical and Mathematical Foundations

This document provides a simplified explanation of the theoretical and mathematical concepts underlying the algorithms provided. Each section corresponds to an algorithm and explains its foundations in an accessible way, focusing on clarity and practical understanding.

##  How to Use This Document

- **For Each Algorithm:** Refer to the relevant section to understand its theoretical and mathematical basis.
- **Simplified Explanations:** Concepts are broken down into straightforward terms, with minimal use of complex jargon.
- **Mathematical Details:** Core mathematical principles are summarized, accompanied by examples if needed.

---

### Algorithm 1: RSA (Rivest-Shamir-Adleman)

**1. Theoretical Foundation:**
- RSA is a public-key cryptographic algorithm used for secure data transmission.
- It is based on the principle of asymmetric encryption, where two keys (public and private) are used.

**2. Mathematical Foundation:**
- RSA relies on the difficulty of factoring large integers.
- Key steps involve:
  - Choosing two large prime numbers, \( p \) and \( q \).
  - Computing \( n = p \times q \) and \( \phi(n) = (p-1)(q-1) \).
  - Selecting an integer \( e \) such that \( 1 < e < \phi(n) \) and \( gcd(e, \phi(n)) = 1 \).
  - Calculating \( d \) such that \( d \times e \equiv 1 \mod \phi(n) \).
- Encryption: \( c = m^e \mod n \).
- Decryption: \( m = c^d \mod n \).

**Example:** Encrypting a message using a public key and then securely decrypting it using the corresponding private key to ensure confidentiality and authenticity.

---

### Algorithm 2: AES (Advanced Encryption Standard)

**1. Theoretical Foundation:**
- AES is a symmetric-key encryption algorithm widely used for securing data.
- It operates on fixed block sizes (128 bits) and supports key lengths of 128, 192, or 256 bits.

**2. Mathematical Foundation:**
- AES is based on substitution-permutation networks.
- Key operations include:
  - SubBytes (non-linear substitution).
  - ShiftRows (cyclically shifting rows of the state).
  - MixColumns (matrix multiplication over a finite field).
  - AddRoundKey (XORing the state with a round key).
- Repeated rounds (10, 12, or 14) depending on the key size.

**Example:** Encrypting a plaintext block using a 128-bit key and securely decrypting it using the same key.

---

### Algorithm 3: Hash Functions

**1. Theoretical Foundation:**
- A hash function is an algorithm that maps data of arbitrary size to a fixed-size value, called a hash.
- It is widely used for data integrity, digital signatures, and password storage.
- Hash functions are deterministic, meaning the same input always produces the same output.

**2. Mathematical Foundation:**
- Hash functions use modular arithmetic and bitwise operations to generate unique hash values.
- Properties:
  - **Pre-image resistance:** Hard to reverse-engineer the input from the output.
  - **Collision resistance:** Hard to find two inputs with the same output.
  - **Avalanche effect:** Small changes in input cause significant changes in output.

**Example:** Common hash functions include MD5, SHA-1, and SHA-256. For instance, hashing the string "hello" with SHA-256 produces a unique 256-bit output. These functions ensure data integrity by detecting any alteration in the original input.

---

### Guidelines for Adding New Algorithms

When adding new algorithms to this document:
1. Provide a clear and concise theoretical overview.
2. Highlight the main mathematical principles.
3. Include examples where applicable to enhance understanding.

---

*This document aims to serve as a learning and reference guide for understanding the foundational aspects of algorithms in a straightforward manner.*





