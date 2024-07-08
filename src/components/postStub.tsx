import React from 'react'
import Button from './Button'

export interface PostStubProps {
  showHr?: boolean
}

export default function PostStub (props: PostStubProps) {
  return (
    <>
      <section className="flex flex-row justify-center items-center gap-10">
        <div
          id="imageStub"
          className="w-24 h-24 bg-mountain-mist-300 rounded-full"
        ></div>
        <div id="postStubBody" className="flex flex-col w-7/12">
          <div id="postDate" className="my-5 text-mountain-mist-200">
            7th July, 2024
          </div>
          <div id="postHeading" className="text-2xl my-5">
            First Article of the greatest blog site in the World
          </div>
          <div id="postSnippet">
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Beatae qui
            sapiente velit repellat, porro atque quis eveniet praesentium sunt
            illo facere provident, rerum ad, eligendi fugit nesciunt vitae
            dolorum sint!
          </div>
          <div id="postTagsButtons" className="my-5">
            <div className="mt-3 flex flex-row justify-between">
              <div
                id="tags"
                className="flex flex-row justify-start items-start text-dust-storm-400 gap-5 font-light text-sm"
              >
                <span className="rounded-md p-2 hover:border-dust-storm-400 hover:cursor-pointer hover-draw-border box-border">
                  # CSharp
                </span>
                <span className="rounded-md p-2 hover:border-dust-storm-400 hover:cursor-pointer hover-draw-border box-border">
                  # EFCore
                </span>
                <span className="rounded-md p-2 hover:border-dust-storm-400 hover:cursor-pointer hover-draw-border box-border">
                  # Asp.Net
                </span>
              </div>
              <Button
                buttonText={'Read More'}
                specificStyle="bg-old-brick-800 p-4 rounded border-old-brick-200 hover:bg-old-brick-700 hover:text-white"
              />
            </div>
          </div>
        </div>
      </section>
      {props.showHr && props.showHr ? <hr className="border-mountain-mist-700 border w-6/12" /> : null}
    </>
  )
}