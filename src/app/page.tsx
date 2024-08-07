import Cta from '@/components/cta'
import PostStub from '@/components/postStub'

function generateVariableLengthArrayWithAnyType<T>(arrayLength: number, whatShouldTheArrayBeMadeOf: T) {
  const array = new Array<T>(arrayLength)
  for (let i = 0; i < arrayLength; i++) {
    array.push(whatShouldTheArrayBeMadeOf)
  }
  return array
}

export default function Home() {
  const test = generateVariableLengthArrayWithAnyType(5, {})
  return (
    <main className="flex min-h-screen flex-col items-center mx-auto text-stone-200">
      <Cta />
      <hr className="border-kabul-300 border w-9/12" />
      {generateVariableLengthArrayWithAnyType<string>(5, 'helloworld').map((thing, idx, arr) => (
        <PostStub key={idx} showHr={idx != arr.length - 1} />
      ))}
    </main>
  )
}
