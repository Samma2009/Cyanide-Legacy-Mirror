function(block, generator) {
    // Print statement.
    const msg = generator.statementToCode(block, 'TEXT', Blockly.JavaScript.ORDER_NONE) || "''";
    return 'kprint(' + msg + ');\n';
}
