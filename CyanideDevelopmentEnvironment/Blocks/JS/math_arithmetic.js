function(block, generator) {
    // Basic arithmetic operators, and power.
    const OPERATORS = {
        ADD: [" + ", javascript.Order.ADDITIVE],
        MINUS: [" - ", javascript.Order.ADDITIVE],
        MULTIPLY: [" * ", javascript.Order.MULTIPLICATIVE],
        DIVIDE: [" / ", javascript.Order.MULTIPLICATIVE],
        POWER: [" ^ ", javascript.Order.EXPONENTIATION]
    }
    const tuple = OPERATORS[block.getFieldValue("OP")]
    const operator = tuple[0]
    const order = tuple[1]
    const argument0 = generator.statementToCode(block, "A") || "0"
    const argument1 = generator.statementToCode(block, "B") || "0"
    const code = argument0 + operator + argument1
    return code

}