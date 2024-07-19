import React from 'react'

export interface TagProps {
  tagText: string
}

export default function Tag(props: TagProps) {
  return (
    <>
      <span className="rounded-md p-2 hover:border-dust-storm-400 hover:cursor-pointer hover-draw-border box-border text-dust-storm-400 gap-5 font-light text-sm">
        # {props.tagText}
      </span>
    </>
  )
}
