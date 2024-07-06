import React from 'react'
import Image from 'next/image'

interface CtaProps {
  headerText: string
  imageUrl?: string
  postDate?: string
  postStatus?: 'featured' | 'normal'
  postTitle?: string
  postQuote?: string
  buttonText?: string
  tagText?: string[]
}

export default function Cta () {
  return (
    <section className="mt-5 mx-auto flex flex-col">
      <header className="flex flex-col text-stone-200">
        <div className="flex flex-row gap-8 justify-start mb-4 mx-auto">
          <span className="postStatus font-semibold text-old-brick-300">Featured :</span>
          <span className="postDate font-semibold">June 04, 2024</span>
        </div>
        <span className="headerText text-center text-3xl font-bold items-center mb-8">
          First Article for Code Prodigee
        </span>
        <div className="imageUrl mx-auto">
          <Image
            src={'/img/christopher-gower-m_HRfLhgABo-unsplash.jpg'}
            alt={'computer at a table'}
            width={1024}
            height={480}
          />
        </div>
      </header>
      <div className="mx-auto mt-10 mb-6 font-semibold w-6/12 ">
        <span className="">
          Lorem, ipsum dolor sit amet consectetur adipisicing elit. Illum excepturi et fugiat sapiente, labore blanditiis maiores doloribus minus deserunt eius harum reiciendis vel sed ipsam dolore asperiores corrupti repellat? At!
        </span>
      </div>
      <div className="tagText flex flex-row text-sm mx-auto my-2 font-semibold w-6/12">
        <span>#hardware</span>
        <span className="ml-3">#laptops</span>
      </div>
      <div className="buttonArea mx-auto mt-7 mb-6 font-semibold w-6/12">
        <button className="bg-old-brick-800 p-4 rounded border-old-brick-200 font-semibold hover:bg-old-brick-700">
          Continue Reading
        </button>
      </div>
    </section>
  )
}