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
      <p className="">Testing</p>

      {generateVariableLengthArrayWithAnyType<string>(5, 'helloworld').map((thing, idx) => (
        <PostStub key={idx} />
      ))}
    </main>
  )
}
