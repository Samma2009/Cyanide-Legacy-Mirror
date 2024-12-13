//function(block, generator) {
//    let inp = generator.valueToCode(block, 'script', javascript.Order.NONE);
//    let code = "void kmain(void* multiboot_structure)\n{\n" + inp + "\n}\n"
//    return code;
//};


function(block) {
    var code = 'void kmain(void* multiboot_structure) {\n';
    var nextBlock = block.getInputTargetBlock('script');
    while (nextBlock) {
        var tempCode = Gen.blockToCode(nextBlock);
        if (Gen.STATEMENT_PREFIX) {
            tempCode = Gen.prefixLines(
                Gen.STATEMENT_PREFIX.replace(/%1/g,
                    '\'' + nextBlock.id + '\'') + '\n', Gen.INDENT) + tempCode;
        }
        code += tempCode;
        nextBlock = nextBlock.getNextBlock();
    }
    code += '}\n';
    return code;
};