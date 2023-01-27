function generateArray() {
  const randomLength = Math.floor(Math.random() * 10) + 1

  const array = new Array(randomLength)

  for (let i = 0; i < randomLength; i++) {
    array[i] = Math.floor(Math.random() * 1000000)
  }
  return array
}

console.log(generateArray())
console.log(generateArray())
console.log(generateArray())

const result = resultedArray.filter((item) => item.length <= 3)
console.log('inputArray-->', resultedArray)

console.log('result-->', result)

const getLessThreeSymbols = (array) => array.filter((item) => item.length <= 3)
