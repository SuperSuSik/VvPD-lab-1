.section __TEXT,__cstring,cstring_literals
message:
    .asciz "Hello to 6384 from Ilya Suchkov, number 21, group M3O-119BV-26!"

.section __TEXT,__text,regular,pure_instructions
.globl _main

_main:
    stp x29, x30, [sp, #-16]!
    mov x29, sp
    adrp x0, message@PAGE
    add  x0, x0, message@PAGEOFF
    bl   _puts
    mov  w0, #0
    ldp  x29, x30, [sp], #16
    ret