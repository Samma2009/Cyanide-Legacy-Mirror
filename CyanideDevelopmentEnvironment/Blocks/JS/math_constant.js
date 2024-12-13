function(block, generator) {
    // Constants: PI, E, the Golden Ratio, sqrt(2), 1/sqrt(2), INFINITY.
    const CONSTANTS = {
        PI: ["3.141592653", javascript.Order.HIGH],
        E: ["2.718281828459", javascript.Order.HIGH],
        GOLDEN_RATIO: ["1.61803398875", javascript.Order.MULTIPLICATIVE],
        SQRT2: ["1.41421356237", javascript.Order.HIGH],
        SQRT1_2: ["0.707106781187", javascript.Order.HIGH],
        INFINITY: ["2147483647", javascript.Order.HIGH]
    }
    return CONSTANTS[block.getFieldValue("CONSTANT")]
}